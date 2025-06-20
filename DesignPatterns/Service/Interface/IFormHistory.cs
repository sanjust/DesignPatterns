using System;
namespace Momento.Service.Interface
{
	public interface IFormHistory
    {
		public void Push(FormMomento form);
		public FormMomento Pop();
	}
}

