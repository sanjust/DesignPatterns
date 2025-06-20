using System;
using Momento.Service.Interface;

namespace Momento.Service
{
	public class FormHistory : IFormHistory
    {
        Stack<FormMomento> formsStack = new();

        public FormMomento Pop()
        {
            try
            {
                var currentForm = formsStack.Peek();
                formsStack.Pop();
                return currentForm;
            }
            catch (InvalidOperationException ex)
            {
                throw;
            }
        }

        public void Push(FormMomento form)
        {
            formsStack.Push(form);
        }
    }
}

