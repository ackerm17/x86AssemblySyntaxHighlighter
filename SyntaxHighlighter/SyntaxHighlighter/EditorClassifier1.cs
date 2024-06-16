using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;

namespace HelloHighlighter
{
    internal class HelloClassifier : IClassifier
    {
        private readonly IClassificationType _classificationType;

        internal HelloClassifier(IClassificationTypeRegistryService registry)
        {
            _classificationType = registry.GetClassificationType("setupStuff");
        }

        public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;

        public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span)
        {
            var classifications = new List<ClassificationSpan>();
            var text = span.GetText();

            HighlightWord(span, text, ".386", classifications);
            HighlightWord(span, text, ".model", classifications);
            HighlightWord(span, text, ".code", classifications);
            HighlightWord(span, text, ".data", classifications);

            return classifications;
        }

        private void HighlightWord(SnapshotSpan span, string text, string word, List<ClassificationSpan> classifications)
        {
            int start = 0;
            while ((start = text.IndexOf(word, start, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                var wordSpan = new SnapshotSpan(span.Snapshot, new Span(span.Start + start, word.Length));
                classifications.Add(new ClassificationSpan(wordSpan, _classificationType));
                start += word.Length;
            }
        }
    }
}

