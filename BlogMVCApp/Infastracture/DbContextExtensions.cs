﻿using BlogMVCApp.Data;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Infastracture
{
    public static class DbContextExtensions
    {
        public static IEnumerable<ArticleIndexModel> GetPaginatableArticlesData(this BlogDbContext _blogDbContext, int page, int _ItemPerPage)
        {
            return _blogDbContext.Articles.OrderByDescending(art => art.PublishTime).
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
                                                        //ViewCount = x.ViewCount
                                                    }).ToList();

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
    }
}