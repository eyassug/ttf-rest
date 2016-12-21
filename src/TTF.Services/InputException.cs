using System;
using TTF.Services.Models;

namespace TTF.Services
{
    public class InputException : ArgumentException
    {
        public InputException() : base("Input Error!")
        {

        }
        public InputException(Input input) : this()
        {
            Input = input;
        }
        public Input Input { get; private set; }
    }
}
