namespace Sap.UI5.Core
{

    public class FileFactory: IFileFactory
    {
        public TemplateFileModel Template(string template, string name, string directory, string extension)
            => new()
            {
                Extension = extension,
                Directory = directory,
                Template = template,
                Name=name
            };
    }
}
