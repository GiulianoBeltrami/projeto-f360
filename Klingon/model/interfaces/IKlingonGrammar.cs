using Klingon.Alphabet.Grammar;
using Klingon.Factory;

namespace Interfaces.Klingon.Grammar
{
    public interface IKlingonGrammar
    {
        public Prepositions Prepositions { get; }
        public Verbs Verbs { get; }
        public KlingonStructureFactory KlingonStructureFactory { get; }
    }
}