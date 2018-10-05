using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MioBlog.Entities.Concretes;

namespace MioBlog.Business.ValidationRules.FluentValidation
{
    public class PostValidator : AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(p => p.PostCategoryId).NotEmpty().GreaterThan(0);
            RuleFor(p => p.PostTitle).NotEmpty().MaximumLength(100);
            RuleFor(p => p.PostContent).NotEmpty();
            RuleFor(p => p.PostSummary).NotEmpty().MaximumLength(250);
        }
    }
}
