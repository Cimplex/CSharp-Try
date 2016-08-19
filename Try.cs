using System;

namespace Cimplex.Utilities
{
    public static class Try
	{
        #region Actions

        public static Exception Run(this Action func)
        {
            Exception error = null;
            try
            {
                func();
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1>(this Action<T1> func, T1 t1)
        {
            Exception error = null;
            try
            {
                func(t1);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2>(this Action<T1, T2> func, T1 t1, T2 t2)
        {
            Exception error = null;
            try
            {
                func(t1, t2);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3>(this Action<T1, T2, T3> func, T1 t1, T2 t2, T3 t3)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> func, T1 t1, T2 t2, T3 t3, T4 t4)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7, t8);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7, t8, t9);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            Exception error = null;
            try
            {
                func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            return error;
        }

        #endregion Actions

        #region Functions

        public static Exception Run<TResult>(this Func<TResult> func, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func();
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, TResult>(this Func<T1, TResult> func, T1 t1, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 t1, T2 t2, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 t1, T2 t2, T3 t3, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, out TResult result)
        {
            Exception error = null;
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
            }
            catch (Exception ex)
            {
                error = ex;
                result = default(TResult);
            }
            return error;
        }

        #endregion Functions

        #region Functions (Nullable Return)

        public static Exception Run<TResult>(this Func<TResult> func, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func();
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, TResult>(this Func<T1, TResult> func, T1 t1, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 t1, T2 t2, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 t1, T2 t2, T3 t3, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }

        public static Exception Run<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, out TResult? result)
            where TResult : struct
        {
            try
            {
                result = func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
                return null;
            }
            catch (Exception ex)
            {
                result = null;
                return ex;
            }
        }
        #endregion Nullable Functions
    }
}
