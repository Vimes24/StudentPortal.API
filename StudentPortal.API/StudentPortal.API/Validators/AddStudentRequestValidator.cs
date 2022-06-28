using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using StudentPortal.API.DomainModels;
using StudentPortal.API.Repositories;

namespace StudentPortal.API.Validators
{
    public class AddStudentRequestValidator: AbstractValidator<AddStudentRequest>
    {
        public AddStudentRequestValidator(IStudentRepository studentRepository)
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.DateofBirth).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.PhoneNumber).GreaterThan(99999).LessThan(1000000000);
            RuleFor(x => x.GenderId).NotEmpty().Must(id => 
            {
                var gender = studentRepository.GetGenderAsync().Result.ToList().FirstOrDefault(x => x.Id == id);

                if (gender != null)
                {
                    return true;
                }
                return false;
            }).WithMessage("Please select a valid gender");
            RuleFor(x => x.PhysicalAddress).NotEmpty();
            RuleFor(x => x.PostalAddress).NotEmpty();
        }
    }
}
