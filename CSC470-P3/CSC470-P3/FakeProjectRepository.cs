using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSC470_P3
{
    class FakeProjectRepository : IProjectRepository
    {
        const string NO_ERROR = "";
        const string MODIFIED_PROJECT_ID_ERROR =  "Can not modify the project id.";
        const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        const string NO_PROJECT_FOUND_ERROR = "No project found";
        const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank";



        private static List<Project> projects;

        public FakeProjectRepository()
        {
            if(projects.Count == 0)
            {
                projects = new List<Project>();

                projects.Add(new Project
                {
                    Name = "Big Project"
                });
                projects.Add(new Project
                {
                    Name = "Small Project"
                });
                projects.Add(new Project
                {
                    Name = "Kermit the Frogs Big Adventure"
                });
            }
        }

        int GetNextID()
        {
            int max = -1;

            List<Project> project = GetAll();

            if (project.Count == 0)
                return 1;

            foreach(Project newProject in GetAll())
            {
                if (newProject.Id > max)
                    max = newProject.Id;
            }

            return max + 1;
        }

        public string Add(Project project, out int id)
        {
            id = GetNextID();
            project.Id = id;

            if (project.Name == "")
                return EMPTY_PROJECT_NAME_ERROR;

            if (IsDuplicateName(project.Name))
                return DUPLICATE_PROJECT_NAME_ERROR;


            projects.Add(project);
            return NO_ERROR;
        }

        public string Remove(int projectId)
        {

        }

        public string Modify(int projectId)
        {

        }

        public List<Project> GetAll()
        {
            return projects;
        }

        public bool IsDuplicateName(string projectName)
        {
            bool isDuplicate = false;
            foreach(Project project in GetAll())
            {
                if (projectName == project.Name)
                    isDuplicate = true;
            }

            return isDuplicate;
        }







    }
}
