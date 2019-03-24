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
    public delegate double delFunc(double val);
    public class FunctionsContainer
    {
      
       private Dictionary<string, delFunc> funcList;
        /**
        * function name: constructor
        * the input: void
        **/
        public FunctionsContainer()
        {
            funcList = new Dictionary<string, delFunc>();
        }
        /**
        * property: Name
        * the input: string
        * property operation: name getter and setter
        **/
        public delFunc this[string funcName]
        {
            get
            {
                if (!funcList.ContainsKey(funcName))
                {
                    funcList[funcName] = value => value;
                }
                return funcList[funcName];
            }

            set
            {
                funcList[funcName] = value;
            }
        }

        /**
        * function name: getAllMissions
        * the input: void
        * the output: List<string>
        * the function operation: gets all missions names
        **/
        public List<string> getAllMissions()
        {
            return new List<string>(funcList.Keys);
        }
    }
}
