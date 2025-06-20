using System;
using Momento.Service.Interface;

namespace Momento.Service
{
	public class FormMomento
	{
		private readonly Form _form;

        public FormMomento(Form form)
		{
			_form = form;
		}

		public Form GetForm() {
			return _form;
		}
	}
}

