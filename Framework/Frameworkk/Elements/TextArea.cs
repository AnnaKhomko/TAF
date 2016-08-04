using Framework.Core.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Elements
{
    public class TextArea : Element
    {
        public TextArea(string xPath) : base (xPath)
        {

        }

        public void SetText(string text)
        {
            IElement.Clear();
            IElement.SendKeys(text);
        }

        public string GetText()
        {
            return IElement.Text;
        }
    }
}
