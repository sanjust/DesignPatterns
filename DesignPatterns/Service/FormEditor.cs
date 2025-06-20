using System;
using Momento.Service.Interface;

namespace Momento.Service
{
	public class FormEditor : IFormEditor
    {
		private Form _form;

		public Form GetForm() {
			return _form;
		}

        public FormMomento Save()
        {
            return new FormMomento(_form);
        }

        public void Type(Form form)
        {
            _form = form;
        }

        public void Undo()
        {
            
        }
    }
}

