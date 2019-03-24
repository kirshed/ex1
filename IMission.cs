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
    public interface IMission
    {
        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        /**
        * property: Name
        * the input: string
        * property operation: name getter
        **/
        String Name { get; }
        /**
        * property: Type
        * the input: string
        * property operation: Type getter
        **/
        String Type { get; }
        /**
        * function name: Calculate
        * the input: double
        * the output: double
        * the function operation: calculates all missions
        **/
        double Calculate(double value);
    }
}
