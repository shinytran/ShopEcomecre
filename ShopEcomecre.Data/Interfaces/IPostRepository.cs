﻿using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Model.Models;
using System.Collections.Generic;

namespace ShopEcomecre.Data.Repositories
{
    public interface IPostRepository :IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }
}