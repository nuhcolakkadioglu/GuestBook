using FluentValidation;
using GuestBook.Core.Dtos.GuestPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Business.ValidationRules
{
    public class GuestPostCreateDtoValidator:AbstractValidator<GuestPostCreateDto>
    {
        public GuestPostCreateDtoValidator()
        {
            RuleFor(m => m.Name).NotEmpty();

            RuleFor(m=>m.PostContent).NotEmpty();
        }
    }
}
