/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 17.04.2020
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_Example
{

    class Overloading
    {
        public int num1 = 0;
        public int num2 = 0;
        public int num3 = 0;

        //We can define multiple type constructor methods. We can send the parameters inside the constructor 
        // and also we can initiazie the class with null variable values.
        // Here we use the both constructors to initialize the class.

        public Overloading()
        { }

        public Overloading(int _num1, int _num2, int _num3)
        {
            num1 = _num1;
            num2 = _num2;
            num3 = _num3;
        }

        //Here we declared two methods with same names.
        //One of them has parameters to summarize the other one has ne parameter.
        //Both of them return the same type of data typed value
        public int Sum()
        {
            return num1 + num2 + num3;
        }

        public int Sum(int _num1, int _num2, int _num3)
        {
            return _num1 + _num2 + _num3;
        }


        //We can also overload the method with different type return value
        //and different type of parameters. One of methods is integer and the other one is double
        public int Multiply()
        {
            return num1 + num2 + num3;
        }

        public int Multiply(int _num1, int _num2, int _num3)
        {
            return num1 + num2 + num3;
        }

        public double Multiply(double _num1, double _num2, double _num3)
        {
            return _num1 + _num2 + _num3;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //We can initialize the class like below. 
            //We can initialize with parameters and without parameters.
            Overloading overloading_with_no_params = new Overloading();
            Overloading overloading_with_params = new Overloading(3, 4, 5);



            //We can call overloaded methods like below.
            //If we want to call the method with no parameter it may be good the variables being declared.
            //So I declared the variables and set the values first. or they probably setted before.
            overloading_with_no_params.num1 = 33;
            overloading_with_no_params.num2 = 34;
            overloading_with_no_params.num3 = 35;
            overloading_with_no_params.Sum();
            //or we can send the values inside the method as parameters.
            //you see we used the same method names and with parameters and with no parameters.
            overloading_with_no_params.Sum(33, 34, 35);



            //We can use the overloaded method.
            overloading_with_no_params.num1 = 33;
            overloading_with_no_params.num2 = 34;
            overloading_with_no_params.num3 = 35;
            overloading_with_no_params.Multiply();
            //And we used the double parametered function like below.
            //Integer variable type does not take the floated numbers.
            overloading_with_no_params.Multiply(33.3, 34.6, 35.8);

        }
    }
}
