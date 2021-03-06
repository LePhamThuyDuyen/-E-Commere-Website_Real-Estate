using KhoaLuanTotNghiep.Data;
using KhoaLuanTotNghiep_BackEnd.Interface;
using KhoaLuanTotNghiep_BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using ShareModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Service
{
    public class CategoryService : Icategory
    {
        public readonly ApplicationDbContext _dbContext;
        public CategoryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CategoryModel> CreateCategoryAsync(CategoryModel categoryModel)
        {
            var category = await _dbContext.categories.FirstOrDefaultAsync(x => x.CategoryName == categoryModel.CategoryName);
            if (category != null)
            {
                throw new Exception("Category Name is used");
            }

            var cate = new Category
            {
                CategoryID = Guid.NewGuid().ToString(),
                CategoryName = categoryModel.CategoryName,
                Description = categoryModel.Description,
            };
            var create = _dbContext.Add(cate);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return categoryModel;
            }
            throw new Exception("Create category fail");

        }

        public async Task<bool> DeleteCategoryAsync(string id)
        {
            var asset = await _dbContext.categories.FirstOrDefaultAsync(x => x.CategoryID == id);
            if (asset == null)
            {
                throw new Exception("Have not this category");
            }
            var deleted = _dbContext.categories.Remove(asset);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            throw new Exception("Delete category fail");
        }

        public async Task<CategoryModel> GetByIdAsync(string id)
        {
            var queryable = _dbContext.categories.AsQueryable();
            queryable = queryable.Where(p => p.CategoryID == id);
            var real = await queryable.Select(p => new CategoryModel
            {
                CategoryID = p.CategoryID,
                CategoryName = p.CategoryName,
                Description = p.Description,
            }).FirstOrDefaultAsync();
            return real;
        }

        public async Task<ICollection<CategoryModel>> GetListCategoryAsync()
        {
            return await _dbContext.categories
                .Select(category => new CategoryModel
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    Description = category.Description
                })
                .ToListAsync();
        }

        public async Task<CategoryModel> UpdateCategoryAsync(string id, CategoryModel categoryModel)
        {
            var category = await _dbContext.categories.FirstOrDefaultAsync(x => x.CategoryID == id);
            if (category == null)
            {
                throw new Exception("Have not this category");
            }
            category.CategoryName = categoryModel.CategoryName;
            category.Description = categoryModel.Description;
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return categoryModel;
            }
            throw new Exception("Delete category fail");

        }
    }
}
