using System;using R5T.T0064;


namespace R5T.Smyni
{[ServiceDefinitionMarker]
    /// <summary>
    /// Performs operations on a Visual Studio solution file.
    /// </summary>
    public interface IVisualStudioSolutionFileOperator:IServiceDefinition
    {
        string CreateSolutionFile(string solutionDirectoryPath, string solutionName);

        void AddProjectFileToSolutionFile(string solutionFilePath, string projectFilePath);
    }
}
