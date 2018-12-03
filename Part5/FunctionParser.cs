using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;



namespace Part5
{
    public class FunctionParser
    {
        private static Regex num;
        private static Regex binaryOp;
        private static Regex var;
        private static Regex unarFunc;
        private static Regex openBr;
        private static Regex closeBr;
        private static Regex negativeNum;
        private static Regex exp;
        private static Regex unarFuncWithVar;
        private readonly string originalExp;
        private string workingExp;
        private LinkedList<string> postfixForm;
        private double[] currPoint;
        LinkedList<string> vars;



        static FunctionParser()
        {
            negativeNum = new Regex(@"(\(|^)-(\d+(,\d+)?)");
            unarFunc = new Regex(@"(sin|cos|tg|ln)\((\d+(,\d+)?)\)");
            unarFuncWithVar = new Regex(@"(sin|cos|tg|ln)\(([a-zA-Z]\w{1,3})\)");
            num = new Regex(@"^~?\d+(,\d+)?");
            binaryOp = new Regex(@"^(\+|-|\*|/|\^)");
            var = new Regex(@"^[a-zA-Z]\w{1,3}\s*");
            openBr = new Regex(@"^\(");
            closeBr = new Regex(@"^\)");
            exp = new Regex(@"(\W|^)e(\W|$)");
        }

        public FunctionParser(string strFunc)
        {
            vars = new LinkedList<string>();
            this.originalExp = strFunc;
            convertToPostfixForm1();
            currPoint = new double[vars.Count];
        }

        public LinkedList<String> getFuncVars() { return vars; }

        public int getDimensionality()
        {
            return vars.Count;
        }

        public int extractNum(string str)
        {
            Regex notDigit = new Regex(@"\D");
            return int.Parse(notDigit.Replace(str, "")) - 1;
        }

        public double computeFuncVal(double[] point)
        {
            currPoint = (double[])point.Clone();
            return parse();
        }

        private double parse()
        {
            Stack<string> operStack = new Stack<string>();
            Stack<double> valStack = new Stack<double>();
            string token;
            string firstElem;
            int count = postfixForm.Count;

            for (int i = 0; i < count; i++)
            {
                token = postfixForm.First();
                firstElem = (string) token.Clone();
                double num1, num2;
                if (num.IsMatch(token))
                {
                    token = token.Contains("~") ? token.Replace('~', '-') : token;
                    valStack.Push(double.Parse(token));
                }
                if (unarFuncWithVar.IsMatch(token))
                {
                    Match m = unarFuncWithVar.Match(token);
                    valStack.Push(MathUtil.calculate(m.Groups[1].Value, currPoint[extractNum(m.Groups[2].Value)]));
                }
                else
                {
                    if (var.IsMatch(token))
                    {
                        valStack.Push(currPoint[extractNum(token)]);
                    }
                }
                if (binaryOp.IsMatch(token) && token.Length == 1)
                {
                    num1 = valStack.Pop();
                    num2 = valStack.Pop();
                    valStack.Push(MathUtil.calculate(token, num2, num1));

                }
                postfixForm.RemoveFirst();
                postfixForm.AddLast(firstElem);
            }
            return valStack.Pop();
        }


        public override string ToString()
        {
            return parse().ToString();
        }

        private void convertToPostfixForm1()
        {
            workingExp = originalExp.Replace(" ", "");
            workingExp = exp.Replace(workingExp, "${1}" + Math.Round(Math.E, 8).ToString() + "${2}");
            computeTrigonFunc();
            workingExp = negativeNum.Replace(workingExp, "${1}~${2}");
            postfixForm = new LinkedList<string>();
            Stack<string> operSt = new Stack<string>();
            Stack<string> numSt = new Stack<string>();
            

            while (workingExp != "")
            {
                if (isNumber())
                {
                    Match m = num.Match(workingExp);
                    postfixForm.AddLast(m.Value);
                    workingExp = workingExp.Substring(m.Length);
                    continue;
                }

                if (isBinaryOp())
                {
                    Match m = binaryOp.Match(workingExp);
                    string nextOper;
                    if (operSt.Count != 0)
                    {
                        do
                        {
                            nextOper = operSt.Pop();
                            if (MathUtil.priority(nextOper) < MathUtil.priority(m.Value))
                            {
                                operSt.Push(nextOper);
                                break;
                            }
                            postfixForm.AddLast(nextOper);
                        } while (operSt.Count != 0);
                    }
                    operSt.Push(m.Value);
                    workingExp = workingExp.Substring(m.Length);
                    continue;
                }

                if (isUnarFuncWithVar())
                {
                    Match m = unarFuncWithVar.Match(workingExp);
                    if (!vars.Contains(m.Groups[2].Value)) vars.AddLast(m.Groups[2].Value);
                    postfixForm.AddLast(m.Value);
                    workingExp = workingExp.Substring(m.Length);
                    continue;
                }

                if (isVariable())
                {
                    Match m = var.Match(workingExp);
                    if (!vars.Contains(m.Value)) vars.AddLast(m.Value);
                    postfixForm.AddLast(m.Value);
                    workingExp = workingExp.Substring(m.Length);
                    continue;
                }

                if (isOpenedBracket())
                {
                    Match m = openBr.Match(workingExp);
                    operSt.Push(m.Value);
                    workingExp = workingExp.Substring(m.Length);
                    continue;
                }

                if (isClosedBracket())
                {
                    Match m = closeBr.Match(workingExp);
                    string nextOper = operSt.Pop();
                    while (nextOper != "(")
                    {
                        postfixForm.AddLast(nextOper);
                        nextOper = operSt.Pop();
                    }
                    workingExp = workingExp.Substring(m.Length);
                }
            }

            while (operSt.Count != 0)
            {
                postfixForm.AddLast(operSt.Pop());
            }
        }

        private void computeTrigonFunc()
        {
            MatchCollection matchCollection = unarFunc.Matches(workingExp);
            foreach (Match m in matchCollection)
            {
                workingExp = workingExp
                    .Replace(
                    m.Value, MathUtil.calculate(m.Groups[1].Value, 
                    (double.Parse(m.Groups[2].Value))).ToString().Replace('-', '~')
                    );
            }
        }

        private bool isNumber()
        {
            return num.IsMatch(workingExp);
        }

        private bool isVariable()
        {
            return var.IsMatch(workingExp);
        }

        private bool isBinaryOp()
        {
            return binaryOp.IsMatch(workingExp);
        }

        private bool isOpenedBracket()
        {
            return openBr.IsMatch(workingExp);
        }

        private bool isClosedBracket()
        {
            return closeBr.IsMatch(workingExp);
        }

        private bool isUnarFuncWithVar()
        {
            return unarFuncWithVar.IsMatch(workingExp);
        }


        private double func(double[] param)
        {
            return 0;
        }
        
    }
}
