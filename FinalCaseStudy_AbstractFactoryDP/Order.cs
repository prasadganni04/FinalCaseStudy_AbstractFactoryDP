﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_AbstractFactoryDP
{
    abstract class Order
    {
        public Order(channel channel, productType productType)
        {
            this.Channel = channel;
            this.productType = productType;
        }
        public channel Channel { get; set; }
        public productType productType { get; set; }
        public abstract void processOrder();
    }
}
