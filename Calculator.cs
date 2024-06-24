using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorCsharp
{
   public  class Calculator
    {
        private Dictionary<string, object> operations;

        public Calculator()
        {
            operations = new Dictionary<string, object>
        {
            { "+", new Addition() },
            { "-", new Subtraction() },
            { "*", new Multiplication() },
            { "/", new Division() }
        };
        }

        public double PerformOperation(string operatorSymbol, double a, double b)
        {
            if (operations.ContainsKey(operatorSymbol))
            {
                switch (operatorSymbol)
                {
                    case "+":
                        return ((Addition)operations[operatorSymbol]).Calculate(a, b);
                    case "-":
                        return ((Subtraction)operations[operatorSymbol]).Calculate(a, b);
                    case "*":
                        return ((Multiplication)operations[operatorSymbol]).Calculate(a, b);
                    case "/":
                        return ((Division)operations[operatorSymbol]).Calculate(a, b);
                }
            }
            throw new ArgumentException("Error: Invalid operation");
        }

        public double EvaluateExpression(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);
            return result;
        }
    }

}
