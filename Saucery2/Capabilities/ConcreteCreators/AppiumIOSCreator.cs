﻿using Saucery2.Capabilities.Base;
using Saucery2.Capabilities.ConcreteProducts;
using Saucery2.OnDemand;

namespace Saucery2.Capabilities.ConcreteCreators {
    internal class AppiumIOSCreator : Creator {
        public override BaseCapabilities Create(SaucePlatform platform, string testName) {
            return new AppiumIOSCapabilities(platform, testName);
        }
    }
}
/*
 * Copyright Andrew Gray, Full Circle Solutions
 * Date: 18th September 2014
 * 
 */