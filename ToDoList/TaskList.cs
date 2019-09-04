using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DBConnection;

//Todo Program to add a new task
//Todo Program to list all task


namespace ToDoList
{
    public class TaskLib
    {
        IRepository<Tasklist> taskRepository = new TaskRepository<Tasklist>();

        public IEnumerable<Tasklist> ListAll()
        {
            return taskRepository.GetAll().ToList();
        }

        public IEnumerable<Tasklist> AddNewTask(Tasklist newTask)
        {
            //Add Comment to commit for hackfest
            taskRepository.Add(newTask);
            return ListAll();
        }
    }
}
