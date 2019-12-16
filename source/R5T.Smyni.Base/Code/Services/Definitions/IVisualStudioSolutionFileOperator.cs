using System;


namespace R5T.Smyni
{
    /// <summary>
    /// Performs operations on a Visual Studio solution file.
    /// </summary>
    public interface IVisualStudioSolutionFileOperator
    {
        void CreateNewSolutionFile(string solutionDirectoryPath, string solutionName);
    }
}
