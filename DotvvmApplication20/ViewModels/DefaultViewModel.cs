using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;

namespace DotVVM.StaticCommandPerf.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		public string Title1 { get; set;} = "Hello from DotVVM!";
        public string Title2 { get; set; } = "Hello from DotVVM!";
        public string Title3 { get; set; } = "Hello from DotVVM!";
        public string Title4 { get; set; } = "Hello from DotVVM!";
        public string Title5 { get; set; } = "Hello from DotVVM!";
        public string Title6 { get; set; } = "Hello from DotVVM!";
        public string Title7 { get; set; } = "Hello from DotVVM!";
        public string Title8 { get; set; } = "Hello from DotVVM!";
        public string Title9 { get; set; } = "Hello from DotVVM!";
        public string Title10 { get; set; } = "Hello from DotVVM!";
        public string Title11 { get; set; } = "Hello from DotVVM!";

        public string Title01 { get; set; } = "Hello from DotVVM!";
        public string Title02 { get; set; } = "Hello from DotVVM!";
        public string Title03 { get; set; } = "Hello from DotVVM!";
        public string Title04 { get; set; } = "Hello from DotVVM!";
        public string Title05 { get; set; } = "Hello from DotVVM!";
        public string Title06 { get; set; } = "Hello from DotVVM!";
        public string Title07 { get; set; } = "Hello from DotVVM!";
        public string Title08 { get; set; } = "Hello from DotVVM!";
        public string Title09 { get; set; } = "Hello from DotVVM!";
        public string Title010 { get; set; }= "Hello from DotVVM!";
        public string Title011 { get; set; } = "Hello from DotVVM!";

        public void SetTitle(string adition)
        {
            Title1 = "Ahoj světe." + adition;
        }

        [AllowStaticCommand]
        public static string GetTitle(string addition)
        {
            return "Ahoj světe." + addition;
        }

        public DefaultViewModel()
		{
			Title1 = "Hello from DotVVM!";
		}
    }
}
