using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList;
using ToDoList.DBConnection;
namespace TodoListWinApp
{
    public class TodoListController : ITodoListController
    {
        private ITodoListView _todoListView = null;
        private IRepository<Tasklist> _todoListModel = null;
        public TodoListController(ITodoListView todoListView, IRepository<Tasklist> todoListModel)
        {
            _todoListView = todoListView;
            _todoListModel = todoListModel;

            _todoListView.SetController(this);
        }
        public IEnumerable<ToDoList.DBConnection.Tasklist> GetAllItems()
        {
            return _todoListModel.GetAll();
        }

        public void AddItemtoTodoList(ToDoList.DBConnection.Tasklist task)
        {
            _todoListModel.Add(task);
        }

        public void RemoveItemFromTodoList(ToDoList.DBConnection.Tasklist task)
        {
            _todoListModel.Remove(task);
        }

        public void UpdateItemtoTodoList(ToDoList.DBConnection.Tasklist task)
        {
            _todoListModel.Update(task);
        }

    }
}
