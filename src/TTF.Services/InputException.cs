using System;
using TTF.Services.Models;

namespace TTF.Services
{
    public class InputException : ArgumentException
    {
        public InputException(Input input) : base("Input Error!")
        {
            Input = input;
        }
        public Input Input { get; private set; }
    }
}
