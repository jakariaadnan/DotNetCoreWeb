using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.Areas.MasterData.Models;
using DotNetCore.Data.Entity.MasterData;
using DotNetCore.Services.RepositoryService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Areas.MasterData.Controllers
{
    [Area("MasterData")]
    public class MasterDataController : Controller
    {
        private readonly IRepository<DocumentCategory> _repoDocumentCategory;

        public MasterDataController(IRepository<DocumentCategory> repoDocumentCategory)
        {
            _repoDocumentCategory = repoDocumentCategory;
        }

        public async Task<IActionResult> DocumentCategory()
        {
            var model = new MasterDataViewModel
            {
                documentCategories= _repoDocumentCategory.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DocumentCategory(DocumentCategoryVM model)
        {
            try
            {
                if (model.CategoryName != null)
                {
                    var check = _repoDocumentCategory.Get(Convert.ToInt32(model.categoryId));
                    if (model.categoryId == 0) {
                        var data = new DocumentCategory
                        {
                            Id= Convert.ToInt32(model.categoryId),
                            categoryName = model.CategoryName,
                            categoryCode = model.CategoryNameBn,
                            status =Convert.ToInt32(model.categoryStatus)
                        };
                        _repoDocumentCategory.Insert(data);
                        var modelData = new MasterDataViewModel
                        {
                            documentCategories = _repoDocumentCategory.GetAll()
                        };
                        return View(modelData);
                    }
                    else if (check != null)
                    {
                        var data = new DocumentCategory
                        {
                            Id = Convert.ToInt32(model.categoryId),
                            categoryName = model.CategoryName,
                            categoryCode = model.CategoryNameBn,
                            status = Convert.ToInt32(model.categoryStatus)
                        };
                        _repoDocumentCategory.Update(data);
                        var modelData = new MasterDataViewModel
                        {
                            documentCategories = _repoDocumentCategory.GetAll()
                        };
                        return View(modelData);
                    }
                    else
                    {
                        ModelState.AddModelError("Error", model.CategoryName+" Already In Database");
                        var modelData = new MasterDataViewModel
                        {
                            documentCategories = _repoDocumentCategory.GetAll()
                        };
                        return View(modelData);
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Category Name Not Found");
                    var modelData = new MasterDataViewModel
                    {
                        documentCategories = _repoDocumentCategory.GetAll()
                    };
                    return View(modelData);

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                var modelData = new MasterDataViewModel
                {
                    documentCategories = _repoDocumentCategory.GetAll()
                };
                return View(modelData);
            }
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                var data = _repoDocumentCategory.Get(id);
                _repoDocumentCategory.Delete(data);
                return Json("success");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
    }
}