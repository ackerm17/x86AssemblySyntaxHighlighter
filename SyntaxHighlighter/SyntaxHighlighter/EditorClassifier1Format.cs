using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.Windows.Media;

namespace HelloHighlighter
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "setupStuff")]
    [Name("setupStuff")]
    [UserVisible(false)]
    [Order(Before = Priority.Default)]
    internal sealed class SetupFormatDefinition : ClassificationFormatDefinition
    {
        public SetupFormatDefinition()
        {
            this.DisplayName = "highlights for initial setup"; // Human-readable name
            this.ForegroundColor = Colors.LightPink;
        }
    }
}

