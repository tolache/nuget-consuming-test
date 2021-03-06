﻿using System;

namespace ProductNameGetter
{
    public class ProductNameGetter
    {
        public string GetProductName(object product)
        {
            Type type = product.GetType();
            if (type.GetProperty("Name") != null)
            {
                return product.GetType().GetProperty("Name")?.GetValue((dynamic)product);
            }

            throw new PropertyNotFoundException("Object doesn't have a 'Name' property.");
        }
    }
}
