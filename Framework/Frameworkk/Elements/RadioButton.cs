using Framework.Core.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Elements
{
    public class RadioButton : Element
    {
        public RadioButton(string xPath) : base(xPath)
        {
        }
             public void Select()
        {
            if (!IElement.Selected)
            {
                IElement.Click();
            }
        }
    
    }
}
