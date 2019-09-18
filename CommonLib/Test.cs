using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AsyncCOM.TestCommonLib;

namespace AsyncCOM.NewCommonLib
{   
    public class Test
    {
        Factory factory;

        public Test()
        {
            factory = new Factory();
        }
         
        public async Task<string> MyAsyncronousMethod()
        {
            var comResult = factory.COMDependentMethod();

            var client = new HttpClient();
            var httpResp = await client.GetAsync("https://jsonplaceholder.typicode.com/comments?postId=1", HttpCompletionOption.ResponseContentRead);
            
            return await httpResp.Content.ReadAsStringAsync();
        }

        public string MySyncronousMethod()
        {
            return "syncronous result";
        }
    }

}
