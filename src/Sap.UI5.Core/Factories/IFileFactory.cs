namespace Sap.UI5.Core
{
    public interface IFileFactory
    {
        TemplateFileModel Template(string template, string name, string directory, string extension);
    }
}
