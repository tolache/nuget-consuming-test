﻿using System;

namespace ProductNameGetter2
{
    public class PropertyNotFoundException : Exception
    {
        public PropertyNotFoundException() : base("Object doesn't have a property with the specified name.")
        {
        }

        public PropertyNotFoundException(string message) : base(message)
        {
        }
    }
}