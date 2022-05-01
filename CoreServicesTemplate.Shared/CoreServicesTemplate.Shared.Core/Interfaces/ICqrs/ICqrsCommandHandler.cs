﻿using System.Threading.Tasks;

namespace CoreServicesTemplate.Shared.Core.Interfaces.ICqrs
{
    public interface ICqrsCommandHandler<in T>
    {
        public Task HandleAsync(T model);
    }
}