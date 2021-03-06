using Humanizer;
using Microsoft.EntityFrameworkCore.Design;

namespace RevEng.Core
{
    public class HumanizerPluralizer : IPluralizer
    {
        public string Pluralize(string name)
           => name?.Pluralize(inputIsKnownToBeSingular: false);

        public string Singularize(string name)
            => name?.Singularize(inputIsKnownToBePlural: false);
    }
}