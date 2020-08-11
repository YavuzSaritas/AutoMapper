using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMapper.Models;
using AutoMapper.Entities;
using AutoMapperExample.DTO;
using Microsoft.EntityFrameworkCore;

namespace AutoMapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext _context;
        private IMapper _mapper;
        public HomeController(ILogger<HomeController> logger,ApplicationContext context,IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var users = _context.User.Include("Adress").Where(p => !p.IsDeleted).ToList();
            var userVM = _mapper.Map<List<UserViewModel>>(users);
            return View(userVM);
        }

      
    }
}
