using TTF.Services.Models;

namespace TTF.Services
{
    public abstract class MappingAlgorithm : IMappingAlgorithm
    {
        protected abstract X ComputeX(IInputX input);
        protected abstract double ComputeY(X x, IInputY input);
        public abstract Output Compute(Input input);
        
    }
}
