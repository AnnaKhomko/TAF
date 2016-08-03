using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Element;

namespace Frameworkk.Elements
{
    public class Button : Element
    {

        public Button(string xPath) : base(xPath)
        {
            
        }

        public void Click()
        {
            IElement.Click();
        }
    }
}
