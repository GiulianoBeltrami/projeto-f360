using Interfaces.Klingon.Grammar;
using Interfaces.Klingon.Numbers;
using Interfaces.Klingon.Structure;
using Interfaces.Klingon.Vocabularies;
using Klingon.Alphabet.Grammar;
using Klingon.Alphabet.Structure;
using Klingon.Alphabet.Vocabulary;
using Klingon.Numbers;

namespace Klingon.Factory
{
    public class KlingonStructureFactory : IKlingonStructure
    {
        public Foo Foo { get => new Foo(); }
        public Bar Bar { get => new Bar(); }
    }

    public class KlingonGrammarFactory : IKlingonGrammar
    {
        public Prepositions Prepositions { get => new Prepositions(KlingonStructureFactory); }
        public Verbs Verbs { get => new Verbs(KlingonStructureFactory); }
        public KlingonStructureFactory KlingonStructureFactory { get => new KlingonStructureFactory(); }
    }

    public class KlingonVocabularyFactory : IKlingonVocabulary
    {
        public Vocabulary Vocabulary { get => new Vocabulary(); }
    }

    public class KlingonNumberFactory : IKlingonNumber
    {
        public Number Number { get => new Number(); }
    }

}