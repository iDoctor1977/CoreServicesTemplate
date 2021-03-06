using System;
using System.Globalization;
using CoreServicesTemplate.Console.Web.Models;
using CoreServicesTemplate.Shared.Core.Bases;
using CoreServicesTemplate.Shared.Core.Models;

namespace CoreServicesTemplate.Console.Web.Receivers
{
    public class CreateUserCustomReceiver : AConsolidatorBase<UserViewModel, UserApiModel>
    {
        public CreateUserCustomReceiver(IServiceProvider service) : base(service) { }

        public override UserApiModel ToData(UserViewModel viewModel)
        {
            var model = ToExternalData(viewModel);
            model.Birth = DateTime.ParseExact(viewModel.Birth, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            return model;
        }
    }
}