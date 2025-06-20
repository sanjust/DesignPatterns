using System;
namespace Momento.Service.Interface
{
	public interface IFormEditor
    {
		public void Type(Form form);
        public FormMomento Save();
        public void Undo();
        public Form GetForm();
    }
}

