﻿namespace NUnitTestGenerator.Core.ItemInfo;

internal class MethodInformation
{
    public MethodInformation(string name, string returnType,
                             IDictionary<string, string> parametersNameTypeDictionary)
    {
        ReturnType = returnType;
        Name = name;
        ParametersNameTypeDictionary = parametersNameTypeDictionary
            .ToDictionary(pair => pair.Key, pair => pair.Value);
    }

    public string Name { get; set; }
    public string ReturnType { get; set; }
    public IDictionary<string, string> ParametersNameTypeDictionary { get; set; }
}
