using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public ValidationException(ValidationResult validationResult) : base("One or more validation failures have occured.")
        {
            foreach (var error in validationResult.Errors) { 
                Errors.Add(error.ErrorMessage); }
        }
    }
}
