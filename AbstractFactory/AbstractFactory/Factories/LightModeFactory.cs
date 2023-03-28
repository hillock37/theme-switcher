using AbstractFactory.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LightModeFactory : SwitchMode
    {
        public override Background GetBackgroundColor()
        {
            return new LightBackground();
        }
        public override LettersColor GetLettersColor()
        {
            return new DarkLetters();
        }
    }
}
