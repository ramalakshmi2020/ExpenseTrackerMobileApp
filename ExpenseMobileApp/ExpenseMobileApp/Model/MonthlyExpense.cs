using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseMobileApp.Model
{
    public class MonthlyExpense
    {
        public double Budget { get; set; }

        public List<Expense> ExpenseList { get; set; }

        public int Month { get; set; }

        public double Balance
        {
            get
            {
                //calculate balace based on expenses
                double totalExp = 0;
                if (ExpenseList != null)
                {
                    ExpenseList.ForEach(exp => totalExp += exp.Amount);
                }
                return Budget - totalExp;
            }
        }
    }
}
