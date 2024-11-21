using System;

namespace CSharpTraining
{
    class InstanceMember
    {
        float Mass = 96.8859F;
        float Length;
        float Time;
       
        public InstanceMember(float length, float time)
        {
            this.Length = length;
            this.Time = time;
        }

        public float CalculateLY()
        {
            return this.Mass * Length / Time;
        }

        public static void MemberExample()
        {
            Console.WriteLine("Enter the Length and Time to find LY :");
            float value1 = Convert.ToInt32(Console.ReadLine());
            float value2 = Convert.ToInt32(Console.ReadLine());
            InstanceMember obj = new InstanceMember(value1, value2);
            float LYNo = obj.CalculateLY();
            Console.WriteLine("The LY for Instance Method is  : {0}", LYNo);
        }
    }
}
