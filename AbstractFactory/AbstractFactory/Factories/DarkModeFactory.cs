using AbstractFactory.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class DarkModeFactory : SwitchMode
    {
        public override Background GetBackgroundColor()
        {
            return new DarkBackground();
        }
        public override LettersColor GetLettersColor()
        {
            return new LightLetters();
        }
    }
}
