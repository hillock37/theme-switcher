using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class WebPage
    {
        private readonly Background _background;
        private readonly LettersColor _lettersColor;

        public WebPage(SwitchMode mode)
        {
            _background = mode.GetBackgroundColor();
            _lettersColor = mode.GetLettersColor();
        }

        public string DescribeTheme()
        {
            return $"Background color: {_background.GetType().Name}\nLetters color: {_lettersColor.GetType().Name}";
        }
    }
}
