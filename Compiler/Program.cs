using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

namespace Compiler
{
    class functions
    {
        
        public void variables(string var, int score)
        {
            
            CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");
            if (provider.IsValidIdentifier(var))
            {
                Console.WriteLine("Token number: "+ score + " ----- < variable, " + var + " >");
                
            }
        }
        

        public void keywords(string key, int score)
        {
            

            Dictionary<string, string> dictkeywords = new Dictionary<string, string>()
                {
                {"abstract","abstract" },
                {"byte","byte" },
                {"class","class" },
                {"delegate","delegate" },
                {"event","event" },
                {"fixed","fixed" },
                {"if","if" },
                {"internal","internal" },
                {"new","new" },
                {"override","override" },
                {"readonly","readonly" },
                {"short","short" },
                {"struct","struct" },
                {"try","try" },
                {"unsafe","unsafe" },
                {"switch","switch" },
                {"do","do" },
                {"while","while" },
                {"catch","catch" },
                {"continue","continue" },
                {"this","this" },
                {"using","using" },
                {"else","else" },
                {"return","return" },
                {"private","private" },
                {"for","for" },
                {"static","static" },
                {"foreach","foreach" },
                {"protected","protected" },
                {"throw","throw" },
                {"break","break" },
                {"true","true" },
                {"namespace","namespace" },
                {"interface","interface" },
                {"public","public" },
                {"enum","enum" },
                {"false","false" }

                };

            for (int i = 0; i < dictkeywords.Count; i++)
            {
                if (key == dictkeywords.Keys.ElementAt(i))
                {
                    Console.WriteLine("Token number: " +score+ " ----- < Keyword, {0} >", dictkeywords.Keys.ElementAt(i));

                    
                    break;
                }
            }

        }

        public void symbols(string dictsym, int score)
        {
            

            Dictionary<string, string> dictSymbol = new Dictionary<string, string>()
                {
                {"(","opening round bracket" },
                {")","closing round bracket" },
                {"{","opening curly bracket" },
                {"}","closing curly bracket" },
                {"[","opening square bracket" },
                {"]","closing square bracket" },
                {",","comma" },
                {";","semi colon" }
                };

            for (int i = 0; i < dictSymbol.Count; i++)
            {
                if (dictsym == dictSymbol.Keys.ElementAt(i))
                {
                    Console.WriteLine("Token number: " + score + " ----- < {1}, {0} >", dictSymbol.Keys.ElementAt(i),dictSymbol[dictSymbol.Keys.ElementAt(i)]);

                    
                    break;
                }
            }

        }

        public void operators(string dict1, int score)
        {
            

            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"+","Addition Operator" },
                {"-","Subtraction Operator" },
                {"*", "Multiplication Operator"},
                {"/","Division Operator" },
                {"%","Modulus Operator" },
                {"=","Assignment Operator" },
                {"==","Equal to Operator" },
                {">","Greater than Operator" },
                {"<","Less than Operator" },
                {">=","Greater than or Equal to Operator" },
                {"<=","Less than or Equal to Operator" },
                {"!=","Not Equal to Operator" },
                {"||","OR Operator" },
                {"&&","AND Operator" },
                {"++","Increment Operator" },
                {"--","Decrement Operator" },
                {"!","Not Operator" },
                {"~","Bitwise Complement"},
                {"&","Bitwise AND" },
                {"|","Bitwise OR" },
                {"^","Bitwise Exclusive OR" },
                {"<<","Bitwise Left Shift" },
                {">>","Bitwise Right Shift" },
                {"+=","Addition Assignment" },
                {"-=","Subtraction Assignment" },
                {"*=","Multiplication Assignment" },
                {"/=","Division Assignment" },
                {"%=","Modulo Assignment" },
                {"&=","Bitwise AND Assignment" },
                {"|=","Bitwise OR Assignment" },
                {"^=","Bitwise XOR Assignment" },
                {"<<=","Left Shift Assignment" },
                {">>=","Right Shift Assignment" },
                {"=>","Lambda Operator" },
                {"sizeof()","Returns the size of a data type" },
                {"typeof()","Returns the type of a class" },
                {"?:","Conditional Expression" },
                {"is","Determines whether an object is of a certain type" },
                {"as","Cast without raising an exception if the cast fails." },
            };

            for (int i = 0; i < dict.Count; i++)
            {
                if (dict1 == dict.Keys.ElementAt(i))
                {
                    Console.WriteLine("Token number: " + score + " ----- < {1}, {0} >", dict.Keys.ElementAt(i),dict[dict.Keys.ElementAt(i)]);

                    
                    break;
                }
            }

        }

        public void datatypes(string dict2, int score)
        {
            
            Dictionary<string, string> dictdata = new Dictionary<string, string>()
            {
                {"string","string" },
                {"int","integer" },
                {"float","float" },
                {"bool","boolean" },
                {"double","double"},
                {"char","character" },
                {"sbyte","sbyte" },
                {"short","short" },
                {"long","long" },
                {"byte","byte" },
                {"ushort","ushort" },
                {"uint","uint" },
                {"ulong","ulong" },
                {"decimal","decimal" },
                {"enum","enumerator" },
                {"struct","structure" },
                {"null","null" }

            };
            for (int i = 0; i < dictdata.Count; i++)
            {
                if (dict2.ToLower() == dictdata.Keys.ElementAt(i))
                {

                    Console.WriteLine("Token number: " + score + " ----- < Data type, {0} >", dictdata[dictdata.Keys.ElementAt(i)]);

                  
                    break;

                }
            }

        }

        public void identifiers(string rest,int score)
        {
            byte[] asciiInput = Encoding.ASCII.GetBytes(rest);
            foreach (byte element in asciiInput)
            {
                if (element >= 48 && element <= 57)
                {

                    if (rest.Contains("."))
                    {
                        Console.WriteLine("Token number: " + score + " ----- < number, " + rest+" >");
                        break;
                    }
                    Console.WriteLine("Token number: " + score + " ----- < number, " + rest + " >");
                    break;
                }

                
                
            }


        }
        

    }
    class Program:functions
    {
        static void Main(string[] args)
        {
            functions fn = new functions();
            Console.Write("Enter: ");
            int score = 0;
            string userInput = string.Empty;
            string inputval = string.Empty;
            string[] data = { };
            
            label:
            userInput = Console.ReadLine();
            if (userInput != string.Empty)
            {
                inputval += userInput;
                 data = inputval.Split(' ');

                goto label;
            }
            else
            {
                 data = inputval.Split(' ');

                for (int i = 0; i < data.Length; i++)
                {
                    score = i + 1;
                    fn.keywords(data[i], score);

                    fn.datatypes(data[i], score);

                    fn.variables(data[i], score);
                    fn.identifiers(data[i], score);


                    fn.operators(data[i], score);

                    fn.symbols(data[i], score);
                    

                    
                }
                

               
            }

            Console.WriteLine("Total number of tokens: "+score);

              
            Console.ReadKey();
            
        }
    }
}
