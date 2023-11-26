using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTalk
{
    public class SpeakText
    {
        private WebBrowser browser;

        public WebBrowser Browser
        {
            get { return browser; }
            set { browser = value; }
        }

        public SpeakText(WebBrowser browser)
        {
            this.browser = browser;

        }

        private void setText(string text)
        {
            HtmlElement element = browser.Document.GetElementById("ex_textarea");
            element.SetAttribute("value", text);
        }

        private void speak ()
        {
            HtmlElement element = browser.Document.GetElementById("convert-btnname");
            element.InvokeMember("click");
        }

        public void Speak(string data) 
        {
             setText(data);
             speak();
        }

        
    }
}
