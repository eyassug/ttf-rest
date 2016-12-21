using TTF.Services.Models;

namespace TTF.Services
{
    public interface IMappingAlgorithm
    {
        /// <summary>
        /// Computes X & Y values based on the supplied input
        /// </summary>
        /// <param name="input">Input variables (A,B,C,D,E,F)</param>
        /// <returns>Output object containing computed X and Y values</returns>
        Output Compute(Input input);
    }
}
