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
    public class ComposedMission : IMission
    {
        private string cName;
        private List<delFunc> delList;
        /**
        * function name: constructor
        * the input: void
        **/
        public ComposedMission(string compName)
        {
            cName = compName;
            delList = new List<delFunc>();
        }
        /**
        * property: Name
        * the input: string
        * property operation: name getter
        **/
        string IMission.Name => cName;
        /**
        * property: Type
        * the input: string
        * property operation: Type getter
        **/
        string IMission.Type => "Composed";
        
        public event EventHandler<double> OnCalculate;
        /**
        * function name: Calculate
        * the input: double
        * the output: double
        * the function operation: calculates all missions
        **/
        public double Calculate(double value)
        {
            double val = value;
            foreach(delFunc f in delList)
            {
                val = f(val);
            }
            OnCalculate?.Invoke(this, val);
            return val;
        }

        public ComposedMission Add(delFunc func)
        {
            delList.Add(func);
            return this;
        }
    }
}
