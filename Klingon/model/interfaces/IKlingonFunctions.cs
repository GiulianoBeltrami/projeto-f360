using Klingon.Alphabet.Functions;
using Klingon.Factory;

namespace Interfaces.Klingon.Functions
{
    public interface IKlingonFunctions
    {
        public Prepositions Prepositions { get; }
        public Verbs Verbs { get; }
        public KlingonStructureFactory KlingonStructureFactory { get; }
    }
}