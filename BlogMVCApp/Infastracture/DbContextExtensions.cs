using BlogMVCApp.Data;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BlogMVCApp.Infastracture
{
    public static class DbContextExtensions
    {
        public static async Task<IEnumerable<ArticleIndexModel>> GetPaginatableArticlesDataAsync(this BlogDbContext _blogDbContext, int page, int _ItemPerPage)
        {
            return await _blogDbContext.Articles.OrderByDescending(art => art.PublishTime).
                                                    Skip((page - 1) * _ItemPerPage).Take(_ItemPerPage).
                                                    Select(x => new ArticleIndexModel
                                                    {
                                                        Id = x.Id,
                                                        Catigories = x.Catigories.Select(y => new CategoryModel
                                                        {
                                                            Id = y.Id,
                                                            Name = y.Name
                                                        }),
                                                        ImagePath = x.ImagePath,
                                                        PublishTime = x.PublishTime,
                                                        Title = x.Title,
                                                        CommentsCount = x.Comments.Count,
                                                        AuthorName = x.Author.User.UserName,
                                                       // ViewCount = x.ViewCount
                                                    }).ToListAsync();

        }

        public static IEnumerable<CategoryModel> GetCategoriesData(this BlogDbContext _blogDbContext)
        {
            return _blogDbContext.Catigorises.Select(x => new CategoryModel
            {
                Id = x.Id,
                Name = x.Name,
                ArticleCount = x.Articles.Count.ToString()
            }).ToList();
        }

        public static IEnumerable<TagModel> GetTagsData(this BlogDbContext _blogDbContext)
        {
            return _blogDbContext.Tags.Select(x => new TagModel 
            { 
                Id = x.Id,
               Name = x.Name
            }).ToList();
        }

        public static IEnumerable<ArticlePopularModel> GetPopularArticlesData(this BlogDbContext _blogDbContext)
        {
            return _blogDbContext.Articles.OrderByDescending(art => art.ViewCount).Take(3).
                                                    Select(x => new ArticlePopularModel
                                                    {
                                                        Id = x.Id,
                                                        ImagePath = x.ImagePath,
                                                        PublishTime = x.PublishTime,
                                                        Title = x.Title,
                                                        CommentsCount = x.Comments.Count,
                                                        AuthorName = x.Author.User.UserName
                                                    }).ToList();
        }

        public static async Task<IEnumerable<ArticleTravelModel>> GetPaginatableTravelArticlesDataAsync(this BlogDbContext _blogDbContext, int page, int _ItemPerPage)
        {
            return await _blogDbContext.Articles.OrderByDescending(art => art.WrittenTime).
                                                    Skip((page - 1) * _ItemPerPage).Take(_ItemPerPage).
                                                    Select(x => new ArticleTravelModel
                                                    {
                                                        Id = x.Id,
                                                        ImagePath = x.ImagePath,
                                                        WrittenTime = x.WrittenTime,
                                                        Title = x.Title,
                                                        CommentsCount = x.Comments.Count,
                                                        AuthorName = x.Author.User.UserName,
                                                        //AuthorPicture = x.Author.ProfilePicture,
                                                        ViewCount = x.ViewCount
                                                    }).ToListAsync();

        }
    }
}