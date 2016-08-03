using Framework.Core.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkk.Elements
{
    public class Link : Element
    {
        public Link(string xPath) : base (xPath)
        {

        }

        public void FollowToLink()
        {
            IElement.Click();
        }
    }
}
