namespace Cosmos.Debug.Kernel;

public interface IKernelPanicHandler
{
    void Handle(uint id, string filePath, int lineNumber);
}
