namespace TTF.Services.Models
{
    /// <summary>
    /// Input model required by the REST service
    /// </summary>
    public class Input : IInputX, IInputY
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
    }
}
