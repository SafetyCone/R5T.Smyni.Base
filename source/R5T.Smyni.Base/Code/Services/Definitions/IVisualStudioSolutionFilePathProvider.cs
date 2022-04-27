using System;using R5T.T0064;


namespace R5T.Smyni
{[ServiceDefinitionMarker]
    public interface IVisualStudioSolutionFilePathProvider:IServiceDefinition
    {
        string GetVisualStudioSolutionFilePath(string solutionDirectoryPath, string solutionName);
    }
}
