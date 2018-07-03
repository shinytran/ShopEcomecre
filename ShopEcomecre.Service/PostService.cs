using ShopEcomecre.Data.Infratructure;
using ShopEcomecre.Data.Repositories;
using ShopEcomecre.Model.Models;
using System;
using System.Collections.Generic;


namespace ShopEcomecre.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(string tag, int page, int pageSize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();


        public class PostService : IPostService
        {

            private IPostRepository _postRepository;
            private IUnitOfWork _unitOfWork;


            public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork) {

                this._postRepository = postRepository;
                this._unitOfWork = unitOfWork;
            }

            public void Add(Post post)
            {
                throw new NotImplementedException();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<Post> GetAll()
            {
                throw new NotImplementedException();
            }

            public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<Post> GetAllPaging(string tag, int page, int pageSize, out int totalRow)
            {
                throw new NotImplementedException();
            }

            public Post GetById(int id)
            {
                throw new NotImplementedException();
            }

            public void SaveChanges()
            {
                throw new NotImplementedException();
            }

            public void Update(Post post)
            {
                throw new NotImplementedException();
            }
        }
    }


