using DotNetCore.AspNetCore;
using DotNetCore.Logging;
using Microsoft.Extensions.Hosting;

namespace IdentityService
{
    public class Program
    {
        public static void Main()
        {
            Host.CreateDefaultBuilder().UseSerilog().Run<Startup>();
        }
    }
}
