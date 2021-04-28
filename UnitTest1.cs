using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string tmp = "";
            for (int i = 0; i < 4; i++)
            {
                string temp;
                double b = 3.14;
                int ISelection = 1;
                int left = 0;
                int right = 2;
                bool Isnegative = false;
                if (b < 0)
                {
                    Isnegative = true;
                }
                temp = Convert.ToString(b);
                if (Isnegative)
                {
                    temp = temp.Insert(0, "(");
                    temp = temp.Insert(temp.Length, ")");
                }
                if (ISelection == 1)
                {
                    if (i == left)
                    {
                        temp = temp.Insert(0, "(");
                        temp = temp.Insert(temp.Length, " ");
                    }
                    else if (i == right)
                    {
                        temp = temp.Insert(temp.Length, ") ");
                    }
                    else
                    {
                        temp = temp.Insert(temp.Length, " ");
                    }
                }
                else
                {
                    temp = temp.Insert(temp.Length, " ");
                }
                if (temp.Length == 2)
                {
                    temp = temp.Insert(0, " ");
                }
                else if (temp.Length == 3)
                {
                    temp = temp.Insert(0, " ");
                }
                tmp = tmp.Insert(tmp.Length, temp);

                if (i < 4 - 1)
                {
                    string option = "*";
                    tmp = tmp.Insert(tmp.Length, option);
                    tmp = tmp.Insert(tmp.Length, " ");
                }
                else
                    tmp = tmp.Insert(tmp.Length, "= ");
            }
            Assert.AreEqual("(3.14 * 3.14 * 3.14) * 3.14 = " , tmp);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string tmp = "";
            for (int i = 0; i < 4; i++)
            {
                string temp;
                int b = 6;
                int ISelection = 0;
                int left = 1;
                int right = 2;
                bool Isnegative = false;
                if (b < 0)
                {
                    Isnegative = true;
                }
                temp = Convert.ToString(b);
                if (Isnegative)
                {
                    temp = temp.Insert(0, "(");
                    temp = temp.Insert(temp.Length, ")");
                }
                if (ISelection == 1)
                {
                    if (i == left)
                    {
                        temp = temp.Insert(0, "(");
                        temp = temp.Insert(temp.Length, " ");
                    }
                    else if (i == right)
                    {
                        temp = temp.Insert(temp.Length, ") ");
                    }
                    else
                    {
                        temp = temp.Insert(temp.Length, " ");
                    }
                }
                else
                {
                    temp = temp.Insert(temp.Length, " ");
                }
                if (temp.Length == 2)
                {
                    temp = temp.Insert(0, " ");
                }
                else if (temp.Length == 3)
                {
                    temp = temp.Insert(0, " ");
                }
                tmp = tmp.Insert(tmp.Length, temp);

                if (i < 4 - 1)
                {
                    string option = "+";
                    tmp = tmp.Insert(tmp.Length, option);
                    tmp = tmp.Insert(tmp.Length, " ");
                }
                else
                    tmp = tmp.Insert(tmp.Length, "= ");
            }
            Assert.AreEqual(" 6 +  6 +  6 +  6 = ", tmp);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string tmp = "";
            for (int i = 0; i < 4; i++)
            {
                string temp;
                double b = 9.9;
                int ISelection = 1;
                int left = 1;
                int right = 3;
                bool Isnegative = false;
                if (b < 0)
                {
                    Isnegative = true;
                }
                temp = Convert.ToString(b);
                if (Isnegative)
                {
                    temp = temp.Insert(0, "(");
                    temp = temp.Insert(temp.Length, ")");
                }
                if (ISelection == 1)
                {
                    if (i == left)
                    {
                        temp = temp.Insert(0, "(");
                        temp = temp.Insert(temp.Length, " ");
                    }
                    else if (i == right)
                    {
                        temp = temp.Insert(temp.Length, ") ");
                    }
                    else
                    {
                        temp = temp.Insert(temp.Length, " ");
                    }
                }
                else
                {
                    temp = temp.Insert(temp.Length, " ");
                }
                if (temp.Length == 2)
                {
                    temp = temp.Insert(0, " ");
                }
                else if (temp.Length == 3)
                {
                    temp = temp.Insert(0, " ");
                }
                tmp = tmp.Insert(tmp.Length, temp);

                if (i < 4 - 1)
                {
                    string option = "÷";
                    tmp = tmp.Insert(tmp.Length, option);
                    tmp = tmp.Insert(tmp.Length, " ");
                }
                else
                    tmp = tmp.Insert(tmp.Length, "= ");
            }
            Assert.AreEqual("9.9 ÷ (9.9 ÷ 9.9 ÷ 9.9) = ", tmp);
        }
    }
}
