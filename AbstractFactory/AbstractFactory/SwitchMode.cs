using System.ComponentModel;

namespace AbstractFactory
{
    abstract class SwitchMode
    {
        public abstract Background GetBackgroundColor();
        public abstract LettersColor GetLettersColor();
    }
}