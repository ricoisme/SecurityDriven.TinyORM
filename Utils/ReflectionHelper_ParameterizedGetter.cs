﻿using System;
using System.Collections.Generic;

namespace SecurityDriven.TinyORM.Utils
{
	public static class ReflectionHelper_ParameterizedGetter<T> where T : class
	{
		static Type _typeofT = typeof(T);
		public static Dictionary<string, Func<T, (object, Type)>> Getters = ReflectionHelper_Shared.GetPropertyGetters<T>(type: _typeofT, prefix: ReflectionHelper_Shared.PARAM_PREFIX);
	}// class ReflectionHelper_ParameterizedGetter<T>
}//ns