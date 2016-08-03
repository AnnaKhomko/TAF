using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Element;

namespace Frameworkk.Elements
{
    public class Input : Element
    {

        public Input(string xPath) : base (xPath)
        {
            
        }

        public void SetText(string text)
        {
            IElement.SendKeys(text);
        }
    }
}
