using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace HelloHighlighter
{
    internal static class ClassificationDefinitions
    {
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("setupStuff")]
        internal static ClassificationTypeDefinition HelloGoodbyeType = null;
    }
}

