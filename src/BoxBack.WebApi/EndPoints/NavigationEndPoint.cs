using System;
using System.Security.Claims;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BoxBack.WebApi.Controllers;
using BoxBack.Application.ViewModels.Navigation;
using BoxBack.WebApi.Interfaces;

namespace BoxBack.WebApi.EndPoints
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/navigation")]
    public class NavigationEndPoint : ApiController
    {
        private readonly INavigationAppService _navigationManager;
        private readonly IHttpContextAccessor _httpCA;
        public NavigationEndPoint(INavigationAppService navigationManager, IHttpContextAccessor httpCA) 
        { 
            _navigationManager = navigationManager;
            _httpCA = httpCA;
        }

        /// <summary>
        /// Lista as opções de menu do usuário
        /// </summary>
        /// <param></param>
        /// <returns>Um json com os itens de menu</returns>
        /// <response code="200">Lista de itens</response>
        /// <response code="400">Lista nula</response>
        /// <response code="404">Lista vazia</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Route("my-menu")]
        [HttpGet]
        public async Task<IActionResult> MyMenuAsync()
        {
            #region User resolve
            String userId;
            try
            {  
                userId = _httpCA.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            IEnumerable<VerticalNavItemViewModel> result = new List<VerticalNavItemViewModel>();
            try
            {
                result = await _navigationManager.MyMenuAsync(userId);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            return CustomResponse(200, result);
        }
    }
}