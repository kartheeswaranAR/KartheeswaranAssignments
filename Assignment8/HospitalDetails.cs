using System;

namespace CsharpTraining
{
    public struct HospitalDetails
    {
        private string _name;
        private int _id;
        private int _ward;
        private string _disease;


        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public int Ward
        {
            get { return this._ward; }
            set { this._ward = value; }
        }
        public string Disease
        {
            get { return this._disease; }
            set { this._disease = value; }
        }
      
        public void GetDetails()
        {
            Console.WriteLine("\nThe Patient Details are");
            Console.WriteLine("The Patient Name Is : {0}",Name);
            Console.WriteLine("The Patient ID Is : {0}",ID);
            Console.WriteLine("The Patient Ward Is : {0}",Ward);
            Console.WriteLine("The Patient Disease Is : {0}",Disease);
        }
        public HospitalDetails(string Name, int ID,int Ward,string Disease)
        {
            this._name = Name;
            this._id = ID;
            this._ward= Ward;
            this._disease= Disease;

        }
    }
}
