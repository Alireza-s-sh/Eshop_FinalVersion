﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyEshop.Data.Repositories;

namespace MyEshop.Components
{
    public class ProductGroupsComponent : ViewComponent
    {
        private IGroupRepository _groupRepository;

        public ProductGroupsComponent(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
    

        public async Task<IViewComponentResult> InvokeAsync()
        {
      
            return View("/Views/Components/ProductGroupsComponent.cshtml", _groupRepository.GetGroupForShow());
        }
    }
}
