using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MioBlog.Entities.Concretes;

namespace MioBlog.Business.ValidationRules.FluentValidation
{
    public class PostCategoryValidator : AbstractValidator<PostCategory>
    {
        public PostCategoryValidator()
        {
            RuleFor(p => p.PostCategoryName).NotEmpty().MaximumLength(20);
        }
    }
}
