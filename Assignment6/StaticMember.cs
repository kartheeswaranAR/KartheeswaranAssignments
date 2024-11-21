using System;

namespace CSharpTraining
{
    public class StaticMember
    {
        static float Mass;
        float Length;
        float Time;
        static StaticMember()
        {
            StaticMember.Mass = 96.8859F;
        }

        public StaticMember(float length, float time)
        {
            this.Length = length;
            this.Time = time;
        }

        public float CalculateLY()
        {
            return Mass * Length / Time;
        }

        public static void MemberExample()
        {
            Console.WriteLine("Enter the Length and Time to find LY :");
            float value1 = Convert.ToInt32(Console.ReadLine());
            float value2 = Convert.ToInt32(Console.ReadLine());
            StaticMember obj = new StaticMember(value1, value2);
            float LYNo = obj.CalculateLY();
            Console.WriteLine("The LY for Static Method is  : {0}", LYNo);
        }
    }
}
