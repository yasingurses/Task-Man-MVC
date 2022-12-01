﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Valudation
{
    public class UserValidation:AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name cant be empty")
                                        .MinimumLength(3).WithMessage("User name must be greater than 3")
                                        .MaximumLength(30).WithMessage("User name must be less than 30");
        }

    }
}
