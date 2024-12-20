﻿using System.Collections.Generic;
using CodeYad_Blog.CoreLayer.DTOs.Categories;
using CodeYad_Blog.CoreLayer.Utilities;

namespace CodeYad_Blog.CoreLayer.Services.Categories
{
    public interface ICategoryService
    {
        OperationResult CreateCategory(CreateCategoryDto command);
        OperationResult EditCategory(EditCategoryDto command);
        List<CategoryDto> GetAllCategory();
        CategoryDto GetCategoryBy(int id);
        List<CategoryDto> GetChildCategories(int parentId);
        CategoryDto GetCategoryBy(string slug);
        bool IsSlugExist(string slug);
    }
}