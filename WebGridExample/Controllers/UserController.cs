﻿using System.Web.Mvc;
using WebGridExample.Interface;
using WebGridExample.Repository;
using WebGridExample.ViewModel;

namespace WebGridExample.Controllers
{
    public class UserController: Controller
    {
        private readonly IUserRepository _repository;

        public UserController(): this(new UserRepository()) { }
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        // GET: User
        public ActionResult Index()
        {
            var model = new UserViewModel
            {
                Users = _repository.GetAll()
            };
            return View(model);
        }
    }
}