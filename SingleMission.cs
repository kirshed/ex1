/**************
* Daniella Kirshenbaum
* 317049815
* 798921108
* Excercise1
**************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private delFunc df;
        private string fName;
        /**
        * function name: constructor
        * the input: delFunc, string
        **/
        public SingleMission(delFunc delF, string funcName)
        {
            df = delF;
            fName = funcName;
        }

        /**
        * function name: Name
        * the input: string
        * the output: void
        * the function operation: name getter
        **/
        string IMission.Name => fName;
        /**
        * function name: Type
        * the input: void
        * the output: string
        * the function operation: type getter
        **/
        string IMission.Type => "Single";

        public event EventHandler<double> OnCalculate;

        /**
        * function name: Calculator
        * the input: double
        * the output: double
        * the function operation: calculates mission
        **/
        public double Calculate(double value)
        {
            double val = df(value);
            OnCalculate?.Invoke(this, val);
            return val;
        }
    }
}
