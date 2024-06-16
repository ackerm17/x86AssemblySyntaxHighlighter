using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace HelloHighlighter
{
    [Export(typeof(IClassifierProvider))]
    [ContentType("plaintext")] // Change to your target content type if needed
    internal class HelloClassifierProvider : IClassifierProvider
    {
        [Import]
        internal IClassificationTypeRegistryService ClassificationRegistry = null;

        public IClassifier GetClassifier(ITextBuffer buffer)
        {
            return buffer.Properties.GetOrCreateSingletonProperty<HelloClassifier>(
                () => new HelloClassifier(ClassificationRegistry));
        }
    }
}
