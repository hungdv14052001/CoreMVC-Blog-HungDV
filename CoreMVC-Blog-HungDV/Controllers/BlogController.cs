using CoreMVC_Blog_HungDV.Data;
using CoreMVC_Blog_HungDV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC_Blog_HungDV.Controllers
{
    public class BlogController : Controller
    {
        DAO dao = new DAO();
        EnumList enumList = new EnumList();

        /// <summary>
        /// set View for Index include List Blog
        /// </summary>
        /// <returns>View() of Index</returns>
        public IActionResult Index()
        {
            List<Blog> listBlog = new List<Blog>();
            listBlog = dao.getListBlog();
            ViewData["listCategory"] = enumList.ListCategory;
            ViewData["listPostion"] = enumList.ListPostion;
            return View(listBlog);
        }

        /// <summary>
        /// set View for BlogCreateEdit
        /// </summary>
        /// <param name="id"></param>
        /// <returns>View(blog)</returns>
        public IActionResult BlogCreateEdit(int id)
        {
            var blog = new Blog();
            if (id != 0)
            {
                blog = dao.getBlogById(id);
            }
            else
            {
                blog = new Blog();
            }
            var listCategory = enumList.ListCategory;
            IList<SelectListItem> selectList = new List<SelectListItem>();
            foreach (Category category in listCategory)
            {
                selectList.Add(new SelectListItem { Text = category.Name, Value = category.Id.ToString() });
            }
            ViewBag.selectList = selectList;
            ViewData["listPosition"] = enumList.ListPostion;
            return View(blog);
        }

        /// <summary>
        /// use when user Create Blog or Edit Blog. And check validate for control
        /// </summary>
        /// <param name="blog"></param>
        /// <returns>RedirectToAction("BlogList")</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BlogCreateEdit(Blog blog)
        {
            if (blog.Id == 0)
            {
                dao.addBlog(blog);
            }
            else
            {
                dao.updateBlog(blog);
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// set View for BlogCreateEdit
        /// </summary>
        /// <param name="keySearch"></param>
        /// <returns></returns>
        public IActionResult BlogSearchForm(string keySearch)
        {
            if (string.IsNullOrEmpty(keySearch))
            {
                keySearch = "";
            }
            ViewData["listCategory"] = enumList.ListCategory;
            ViewData["listPostion"] = enumList.ListPostion;
            ViewBag.key = keySearch;
            List<Blog> listBlogByKeySearch = dao.getListBlogByKeySearch(keySearch);
            return View(listBlogByKeySearch);
        }

        /// <summary>
        /// delete Blog from DataBase
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult BlogDelete(int id)
        {
            dao.deleteBlogById(id);
            return RedirectToAction("Index");
        }
    }
}
