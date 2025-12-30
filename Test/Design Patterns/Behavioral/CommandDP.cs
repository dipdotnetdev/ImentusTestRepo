using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Behavioral
{
    public class Document
    {
        public void Open()
        {
            Console.WriteLine("Doc Opened");
        }

        public void Save()
        {
            Console.WriteLine("Doc Saved");
        }
        public void Close()
        {
            Console.WriteLine("Doc Closed");
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class OpenCommand : ICommand
    {
        private Document _document;

        public OpenCommand(Document document)
        {
            this._document = document;
        }

        public void Execute()
        {
            _document.Open();
        }
    }

    public class SaveCommand : ICommand
    {
        private Document _document;

        public SaveCommand(Document document)
        {
            this._document = document;
        }

        public void Execute()
        {
            _document.Save();
        }
    }

    public class CloseCommand : ICommand
    {
        private Document _document;

        public CloseCommand(Document document)
        {
            this._document = document;
        }

        public void Execute()
        {
            _document.Close();
        }
    }

    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand closeCommand;
        private ICommand saveCommand;

        public MenuOptions(ICommand open,  ICommand close, ICommand save)
        {
            this.openCommand = open;
            this.closeCommand = close;
            this.saveCommand = save;
        }

        public void ClickOpen()
        {
            openCommand.Execute();
        }

        public void ClickClose()
        {
            closeCommand.Execute();
        }

        public void ClickSave()
        {
            saveCommand.Execute();
        }
    }
    public class CommandDP
    {
        static void Main1()
        {
            Document document = new Document();
            ICommand openCommand = new OpenCommand(document);
            ICommand closeCommand = new CloseCommand(document);
            ICommand saveCommand = new SaveCommand(document);

            MenuOptions menu = new MenuOptions(openCommand, closeCommand, saveCommand);

            menu.ClickOpen();
            menu.ClickSave();
            menu.ClickClose();

            Console.ReadKey();
        }
    }
}
