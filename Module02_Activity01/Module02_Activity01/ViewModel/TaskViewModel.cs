using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Module02_Activity01.Model;

namespace Module02_Activity01.ViewModel
{
    class TaskViewModel
    {
        // Create a link between Model and ViewModel
        // Add 'using [PROJECT_NAME].Model;'

        public TaskModel TaskModelSet { get; set; }
        public TaskViewModel() 
        {
            TaskModelSet = new TaskModel()
            {
                SubjectCode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3
            };

            // Add a ContentPage in View folder
        }
    }
}
