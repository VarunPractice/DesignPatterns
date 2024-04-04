using System;
using System.Collections.Generic;

namespace DesignPatterns.DesignPatterns.Creational.BuilderPattern
{
    public class Document
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public Dictionary<string, string> Metadata { get; private set; } = new Dictionary<string, string>();
        public List<string> Permissions { get; private set; } = new List<string>();
        public DocumentType Type { get; private set; }

        // Builder class
        public class DocBuilder
        {
            private readonly Document _document = new Document();

            public DocBuilder WithTitle(string title)
            {
                _document.Title = title;
                return this;
            }

            public DocBuilder WithContent(string content)
            {
                _document.Content = content;
                return this;
            }

            public DocBuilder WithMetadata(string key, string value)
            {
                _document.Metadata.Add(key, value);
                return this;
            }

            public DocBuilder WithPermission(string permission)
            {
                _document.Permissions.Add(permission);
                return this;
            }

            public DocBuilder WithType(DocumentType type)
            {
                _document.Type = type;
                return this;
            }

            public Document Build()
            {
                return _document;
            }
        }
    }

    public enum DocumentType
    {
        Word,
        PDF,
        Excel
    }
}
