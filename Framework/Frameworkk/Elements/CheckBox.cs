using Framework.Core.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkk.Elements
{
    public class CheckBox : Element 
    {
        public CheckBox(string xPath) : base (xPath)
        {

        }

        public void Select()
        {
            if (!IElement.Selected)
            {
                IElement.Click();
            }
        }

        public void Deselect()
        {
            if (IElement.Selected)
            {
                IElement.Click();
            }
        }
    }
}
