using System;
using System.Collections.Generic;

namespace CSharpTraining
{
    public class AccessModifierExample
    {
        public string EmpName;
        private int _empID;
        protected string _empdept;
        internal string EmpRole;
        protected internal int EmpSalary;

        public int EmpID
        {
            set { this._empID = value; }
            get { return this._empID; }
        }
        public string EmpDept
        {
            set { this._empdept = value; }
            get { return this._empdept; }
        }
        public static void AccessModifier(List<AccessModifierExample> modifierExamples)
        {
            foreach (AccessModifierExample accmod in modifierExamples)
            {
                Console.WriteLine("The Employee Details are : [{0},{1},{2}] [{3},{4}]", accmod.EmpID,accmod.EmpName,accmod.EmpRole,accmod.EmpDept,accmod.EmpSalary);
            }
        }
    }

    class ClientApp : AccessModifierExample
    {
        public void Clientmethod()
        {
            List<AccessModifierExample> Acclist = new List<AccessModifierExample>();
            Acclist.Add(new AccessModifierExample() {EmpID=11258,EmpName="Kartheeswaran",EmpDept="Networking",EmpRole="System Engineer",EmpSalary=61000});
            Acclist.Add(new AccessModifierExample() {EmpID=11259,EmpName="Balaganesh",EmpDept="Designing",EmpRole="Ui/Ux Developer",EmpSalary=58000});
            Acclist.Add(new AccessModifierExample() {EmpID=11260,EmpName="Sachin Charles",EmpDept="Development",EmpRole="FullStack Developer",EmpSalary=65000});
            Acclist.Add(new AccessModifierExample() {EmpID=11261,EmpName="Muneeshwar",EmpDept="Testing",EmpRole="Testor and FlowChecker",EmpSalary=58000});
            Acclist.Add(new AccessModifierExample() {EmpID=11262,EmpName="Arvind Balaji",EmpDept="Development",EmpRole= "FullStack Developer", EmpSalary=65000});
            Acclist.Add(new AccessModifierExample() {EmpID=11263,EmpName="Dhuru Desh",EmpDept="Marketing",EmpRole="Sales and Marketing Executive",EmpSalary=72000});

            AccessModifierExample.AccessModifier(Acclist);
        }
    }
}
