using System;
using System.IO;

namespace CSharpTraining
{
    public class ExceptionHandlingExample
    {
        public void Exc_HandlingMethod()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"E:\CSharpTraining\Assignments\Assignment14\Example_Exception.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException ex) //specific exceptions
            {
                Console.WriteLine("Please check file available {0} ", ex.FileName);
            }
            catch (Exception ex) //base exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close(); //releasing resources from memory
                }
            }
            
            StreamWriter SW = null;
            try
            {
                SW = new StreamWriter(@"E:\CSharpTraining\Assignments\Assignment14\Example_Exception.txt");
                Console.WriteLine("Enter Data to Added !  :");
                object value = Console.ReadLine();
                SW.WriteLine(value);
                
            }
            catch (FileNotFoundException ex) //specific exceptions
            {
                Console.WriteLine("Please check file available {0} ", ex.FileName);
            }
            catch (Exception ex) //base exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                if (SW != null)
                {
                    SW.Close(); //releasing resources from memory
                }
            }
        }
    }
}
