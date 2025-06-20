using System;
using Microsoft.AspNetCore.Mvc;
using Momento.Service.Interface;

namespace Momento.Controller
{
    [ApiController]
    public class FormController : ControllerBase
	{
		private readonly IFormEditor _formEditor;
        private readonly IFormHistory _formHistory;
        public FormController(IFormEditor formEditor, IFormHistory formHistory)
		{
			_formEditor = formEditor;
            _formHistory = formHistory;
		}

		[Route("/type")]
		[HttpPost]
		public IActionResult TypeForm([FromBody] Form form)
        {
            _formHistory.Push(_formEditor.Save());
            _formEditor.Type(form);
            return Ok();
		}

        [HttpGet("undo")]
        public IActionResult Undo()
        {
            try
            {
                var result = _formHistory.Pop();
                return Ok(result.GetForm());
            }
            catch (InvalidOperationException ex)
            {
                return NotFound("Nothing to undo");
            }
            catch (Exception ex)
            {
                return NotFound("There is some issue");
            }
        }
    }
}

