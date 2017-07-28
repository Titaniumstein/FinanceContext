﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.CrossCuttingConcerns
{
    public interface IExternalMessagePublisher
    {
        void Publish<TMessage>(TMessage message);
    }
}
