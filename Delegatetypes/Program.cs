using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatetypes
{
    class Test
    {
        
        static double Calculate(int x, double y)
        {
            return x + y;
        }

        void Update(int newNumber)
        {

            System.Console.WriteLine(newNumber);
        }

        void Delete(string key)
        {
        }

        void Method4() { }
        int Method5(int data) { return data; }
        bool Method6(string data1, string data2) { return true; }


        staic void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4)
        {
            

        }
            static void Main(string[] args)
            {
            Test _Obj = new Test();
            Func<int, double, double> CalculatePtr = new Func<int, double, double>(_Obj.Calculate);
            Action<int> UpdatePtr = new Action<int>(_Obj.Update);
            Action<String> DeletePtr = new Action<String>(_Obj.Delete);
            Action obj4Object = new Action(_Obj.Method4);
            Func<int, int> obj5Object = new Func<int, int>(_Obj.tMethod5);
            Func<string, string, bool> obj6Object = new Func<string, string, bool>(_Obj.Method6);



        }

    }
}
