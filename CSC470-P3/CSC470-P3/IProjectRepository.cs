using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    interface IProjectRepository
    {
        string Add(Project project, out int id);
        string Remove(int projectId);
        string Modify(int projectId, Project project);
        List<Project> GetAll();
        bool IsDuplicateName(string projectName);
    }
}
