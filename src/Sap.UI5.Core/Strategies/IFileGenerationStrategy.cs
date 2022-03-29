namespace Sap.UI5.Core
{
    public interface IFileGenerationStrategy
    {
        int Order { get; }
        bool CanHandle(FileModel model);
        void Create(dynamic model);
    }
}
