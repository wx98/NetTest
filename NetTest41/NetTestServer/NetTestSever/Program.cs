using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using NetTestBLL;
using NetTestModel;
namespace NetTestSever
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string url = "http://localhost:8889/NetTestService/";
                ServiceHost host = new ServiceHost(typeof(NetTestService), new Uri(url));
                host.Open();
                Console.WriteLine(url + "正在监听……");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.ReadKey();
        }
    }
}
