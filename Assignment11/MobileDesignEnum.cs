using System;

namespace CSharpTraining
{
    public enum Designs
    {
        ButtonType,
        MultiTouch,
        ButtonandTouch,
        UnKnown
    };
    public class MobileDesign
    {
        public string MobileName { get; set; }
        public Designs Design{ get; set; }
    }
    public class EnumClient
    {
        public void MobileDesignMethod()
        {
            MobileDesign[] mobileDesign = new MobileDesign[7];

            mobileDesign[0] = new MobileDesign
            {
                MobileName = "Nokia 5710",
                Design = Designs.ButtonType
            };
            mobileDesign[1] = new MobileDesign
            {
                MobileName = "Samsung Galaxy Note 5Pro",
                Design = Designs.MultiTouch
            };
            mobileDesign[2] = new MobileDesign
            {
                MobileName = "Oneplus 5",
                Design = Designs.MultiTouch
            };
            mobileDesign[3] = new MobileDesign
            {
                MobileName = "BlackBerry KE Yone",
                Design = Designs.ButtonandTouch
            };
            mobileDesign[4] = new MobileDesign
            {
                MobileName = "Karbonn KE",
                Design = Designs.ButtonType
            };
            mobileDesign[5] = new MobileDesign
            {
                MobileName = "BlackBerry KEY2",
                Design = Designs.ButtonandTouch
            };
            mobileDesign[6] = new MobileDesign
            {
                MobileName = "KeyNote TAB 8597",
                Design = Designs.UnKnown
            };
           

            foreach (MobileDesign mobile in mobileDesign)
            {
                Console.WriteLine("The Mobile Details");
                Console.WriteLine("The Mobile Name is : {0}",mobile.MobileName);
                Console.WriteLine("The Mobile Design is : {0}",GetMobileDesign(mobile.Design));
            }

           
        }
        public static string GetMobileDesign(Designs designs)
        {
            switch (designs)
            {
                case Designs.ButtonandTouch:
                    return "This mobile available in button and touch"; 
                case Designs.ButtonType:
                    return "This mobile available in only button"; 
                case Designs.MultiTouch:
                    return "This mobile available in Multi-touch"; 
                case Designs.UnKnown:
                    return "This mobile is out to date";
                default:
                    return "Invalid Mobile Design";
            }
        }
    }
}
