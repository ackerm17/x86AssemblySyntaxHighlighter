using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.Windows.Media;

namespace HelloHighlighter
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "helloGoodbye")]
    [Name("helloGoodbye")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class HelloGoodbyeFormatDefinition : ClassificationFormatDefinition
    {
        public HelloGoodbyeFormatDefinition()
        {
            this.DisplayName = "Hello and Goodbye"; // Human-readable name
            this.ForegroundColor = Colors.Turquoise;
        }
    }
}

