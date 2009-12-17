// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.Invoker
{
	using System;
	using System.Linq.Expressions;

	public interface IFastInvoker
	{
	}

	public interface IFastInvoker<T> :
		IFastInvoker
	{
		void FastInvoke(T target, Expression<Action<T>> expression);
		void FastInvoke(T target, Expression<Action<T>> expression, params object[] args);
		void FastInvoke(T target, Expression<Action<T>> expression, Type[] genericTypes);
		void FastInvoke(T target, Expression<Action<T>> expression, Type[] genericTypes, object[] args);

		void FastInvoke(T target, string methodName);
		void FastInvoke(T target, string methodName, params object[] args);
		void FastInvoke(T target, string methodName, Type[] genericTypes);
		void FastInvoke(T target, string methodName, Type[] genericTypes, object[] args);
	}

	public interface IFastInvoker<T, TResult>
	{
		TResult FastInvoke(T target, string methodName);
		TResult FastInvoke(T target, string methodName, params object[] args);
		TResult FastInvoke(T target, string methodName, Type[] genericTypes);
		TResult FastInvoke(T target, string methodName, Type[] genericTypes, object[] args);

		TResult FastInvoke(T target, Expression<Func<T,TResult>> expression);
		TResult FastInvoke(T target, Expression<Func<T, TResult>> expression, params object[] args);
		TResult FastInvoke(T target, Expression<Func<T, TResult>> expression, Type[] genericTypes);
		TResult FastInvoke(T target, Expression<Func<T, TResult>> expression, Type[] genericTypes, object[] args);
	}
}