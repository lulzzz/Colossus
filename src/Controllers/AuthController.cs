using Aiursoft.Colossus.Data;
using Aiursoft.Colossus.Models;
using Aiursoft.Pylon;
using Aiursoft.Pylon.Attributes;
using Aiursoft.Pylon.Models.ForApps.AddressModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Colossus.Controllers
{
    public class AuthController : AiurController
    {
        public readonly UserManager<ColossusUser> _userManager;
        public readonly SignInManager<ColossusUser> _signInManager;
        public readonly ColossusDbContext _dbContext;

        public AuthController(
            UserManager<ColossusUser> userManager,
            SignInManager<ColossusUser> signInManager,
            ColossusDbContext _context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = _context;
        }

        [AiurForceAuth(preferController: "", preferAction: "", justTry: false, register: false)]
        public IActionResult GoAuth()
        {
            throw new NotImplementedException();
        }

        [AiurForceAuth(preferController: "", preferAction: "", justTry: false, register: true)]
        public IActionResult GoRegister()
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> AuthResult(AuthResultAddressModel model)
        {
            await AuthProcess.AuthApp(this, model, _userManager, _signInManager);
            return Redirect(model.state);
        }
    }
}