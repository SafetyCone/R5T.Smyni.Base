using System;


namespace R5T.Smyni
{
    /// <summary>
    /// Performs operations on a Visual Studio solution file.
    /// </summary>
    public interface IVisualStudioSolutionFileOperator
    {
        string CreateSolutionFile(string solutionDirectoryPath, string solutionName);

        void AddProjectFileToSolutionFile(string solutionFilePath, string projectFilePath);
    }
}
