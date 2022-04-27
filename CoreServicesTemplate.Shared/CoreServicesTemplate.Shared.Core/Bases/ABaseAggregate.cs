﻿using System;
using CoreServicesTemplate.Shared.Core.Models;
using CoreServicesTemplate.Shared.Core.Resources;

namespace CoreServicesTemplate.Shared.Core.Bases
{
    public abstract class ABaseAggregate<T> where T : ABaseModel
    {
        protected readonly T Model;

        protected ABaseAggregate(T model)
        {
            Model = model;

            if (!IsModelValid())
            {
                throw new ApplicationException($"{ErrorMessages.ABaseAggregate_ExceptionErrorString} EDF358B9-A42A-43F5-BAE4-5B67168D810A");
            }
        }

        public abstract T ToModel();
        protected abstract bool IsModelValid();
    }
}
