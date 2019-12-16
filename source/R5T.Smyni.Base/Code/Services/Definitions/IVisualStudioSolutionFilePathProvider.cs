using System;


namespace R5T.Smyni
{
    public interface IVisualStudioSolutionFilePathProvider
    {
        string GetVisualStudioSolutionFilePath(string solutionDirectoryPath, string solutionName);
    }
}
