namespace Sap.UI5.Core
{
    public partial class TemplateFileModel: FileModel
    {
        public string Template { get; init; } = string.Empty;

        public Dictionary<string, object> Tokens { get; init; } = new();

        public TemplateFileModel()
        {

        }
    }
}
