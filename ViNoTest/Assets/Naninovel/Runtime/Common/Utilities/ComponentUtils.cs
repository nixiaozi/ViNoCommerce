﻿// Copyright 2017-2020 Elringus (Artyom Sovetnikov). All Rights Reserved.

using System.Collections.Generic;
using UnityEngine;

namespace Naninovel
{
    public static class ComponentUtils
    {
        /// <summary>
        /// Unlike GetComponentsInChildren, does not include components on the caller object.
        /// </summary>
        public static List<T> GetComponentsOnChildren<T> (this Component component) where T : Component
        {
            var result = new List<T>(component.GetComponentsInChildren<T>());
            var compInCaller = result.Find(c => c.gameObject == component.gameObject);
            if (compInCaller) result.Remove(compInCaller);

            return result;
        }
    }
}
