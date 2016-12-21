namespace TTF.Services.Models
{
    public enum X
    {
        S,
        R,
        T
    }
    /// <summary>
    /// Output model returned by the REST service
    /// </summary>
    public class Output
    {
        public X X { get; set; }
        public double Y { get; set; }
    }
}
