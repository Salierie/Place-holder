using System;
using System.Text.Json;

namespace ph
{
    public static class SerializationHelper
    {
        public static void SaveProject(Project project, string fileName)
        {
            var json = JsonSerializer.Serialize(project);
            File.WriteAllText(fileName, json);
        }
    
        public static Project LoadProject(string fileName)
        {
            var json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Project>(json);
        }
    }
}
