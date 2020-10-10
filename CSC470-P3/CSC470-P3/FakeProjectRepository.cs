using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace CSC470_P3
{
    public class FakeProjectRepository : IProjectRepository
    {
        public const string NO_ERROR = "";
        public const string MODIFIED_PROJECT_ID_ERROR =  "Can not modify the project id.";
        public const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        public const string NO_PROJECT_FOUND_ERROR = "No project found";
        public const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank";



        private static List<Project> projects;

        public FakeProjectRepository()
        {
            if(projects == null)
            {
                projects = new List<Project>();

                projects.Add(new Project
                {
                    Name = "Big Project",
                    Id = 1
                });
                projects.Add(new Project
                {
                    Name = "Small Project",
                    Id = 2
                });
                projects.Add(new Project
                {
                    Name = "Kermit the Frog's Big Adventure",
                    Id = 3
                });
            }
        }

        public int GetNextID()
        {
            int max = -1;

            if (projects == null)
                return 1;

            foreach(Project newProject in projects)
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
            return "";
        }

        public string Modify(int projectId, Project project)
        {
            FakePreferenceRespository fprefr = new FakePreferenceRespository();
            if (Session.project.Name != null)
            {
                if (Int32.Parse(fprefr.GetPreference(Session.appUser.UserName, Session.project.Name)) == projectId)
                {
                    return "Cannot modify your current session project.";
                }
            }
            if (project.Id != projectId)
            {
                return MODIFIED_PROJECT_ID_ERROR;
            }
            if (project.Name == "")
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }
            if (IsDuplicateName(project.Name))
            {
                return DUPLICATE_PROJECT_NAME_ERROR;
            }
            foreach(Project temp in projects)
            {
                if (temp.Id == project.Id)
                {
                    temp.Name = project.Name;
                }
            }
            return NO_ERROR;
        }

        public List<Project> GetAll()
        {
            List<Project> templist = new List<Project>();
            templist = projects;
            return templist;
        }

        public bool IsDuplicateName(string projectName)
        {
            bool isDuplicate = false;
            foreach(Project project in projects)
            {
                if (projectName == project.Name)
                    isDuplicate = true;
            }

            return isDuplicate;
        }

    }
}
