﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MioBlog.Entities.Concretes;

namespace MioBlog.Business.Abstracts
{
    public interface IPostCategoryService
    {
        List<PostCategory> GetAll();

        PostCategory GetById(int postCategoryId);

        PostCategory Add(PostCategory postCategory);

        PostCategory Update(PostCategory postCategory);

        void Delete(PostCategory postCategory);
    }
}
