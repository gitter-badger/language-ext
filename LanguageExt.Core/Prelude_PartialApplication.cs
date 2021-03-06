﻿using System;

namespace LanguageExt
{
    public static partial class Prelude
    {
        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T2, R> par<T1, T2, R>(Func<T1, T2, R> func, T1 a) =>
            (T2 b) => func(a, b);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T3, R> par<T1, T2, T3, R>(Func<T1, T2, T3, R> func, T1 a, T2 b) =>
            (T3 c) => func(a, b, c);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T2, T3, R> par<T1, T2, T3, R>(Func<T1, T2, T3, R> func, T1 a) =>
            (T2 b, T3 c) => func(a, b, c);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T4, R> par<T1, T2, T3, T4, R>(Func<T1, T2, T3, T4, R> func, T1 a, T2 b, T3 c) =>
            (T4 d) => func(a, b, c, d);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T3, T4, R> par<T1, T2, T3, T4, R>(Func<T1, T2, T3, T4, R> func, T1 a, T2 b) =>
            (T3 c, T4 d) => func(a, b, c, d);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T2, T3, T4, R> par<T1, T2, T3, T4, R>(Func<T1, T2, T3, T4, R> func, T1 a) =>
            (T2 b, T3 c, T4 d) => func(a, b, c, d);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T5, R> par<T1, T2, T3, T4, T5, R>(Func<T1, T2, T3, T4, T5, R> func, T1 a, T2 b, T3 c, T4 d) =>
            (T5 e) => func(a, b, c, d, e);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T4, T5, R> par<T1, T2, T3, T4, T5, R>(Func<T1, T2, T3, T4, T5, R> func, T1 a, T2 b, T3 c) =>
            (T4 d, T5 e) => func(a, b, c, d, e);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T3, T4, T5, R> par<T1, T2, T3, T4, T5, R>(Func<T1, T2, T3, T4, T5, R> func, T1 a, T2 b) =>
            (T3 c, T4 d, T5 e) => func(a, b, c, d, e);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T2, T3, T4, T5, R> par<T1, T2, T3, T4, T5, R>(Func<T1, T2, T3, T4, T5, R> func, T1 a) =>
            (T2 b, T3 c, T4 d, T5 e) => func(a, b, c, d, e);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T6, R> par<T1, T2, T3, T4, T5, T6, R>(Func<T1, T2, T3, T4, T5, T6, R> func, T1 a, T2 b, T3 c, T4 d, T5 e) =>
            (T6 f) => func(a, b, c, d, e, f);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T5, T6, R> par<T1, T2, T3, T4, T5, T6, R>(Func<T1, T2, T3, T4, T5, T6, R> func, T1 a, T2 b, T3 c, T4 d) =>
            (T5 e, T6 f) => func(a, b, c, d, e, f);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T4, T5, T6, R> par<T1, T2, T3, T4, T5, T6, R>(Func<T1, T2, T3, T4, T5, T6, R> func, T1 a, T2 b, T3 c) =>
            (T4 d, T5 e, T6 f) => func(a, b, c, d, e, f);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T3, T4, T5, T6, R> par<T1, T2, T3, T4, T5, T6, R>(Func<T1, T2, T3, T4, T5, T6, R> func, T1 a, T2 b) =>
            (T3 c, T4 d, T5 e, T6 f) => func(a, b, c, d, e, f);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T2, T3, T4, T5, T6, R> par<T1, T2, T3, T4, T5, T6, R>(Func<T1, T2, T3, T4, T5, T6, R> func, T1 a) =>
            (T2 b, T3 c, T4 d, T5 e, T6 f) => func(a, b, c, d, e, f);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T7, R> par<T1, T2, T3, T4, T5, T6, T7, R>(Func<T1, T2, T3, T4, T5, T6, T7, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) =>
            (T7 g) => func(a, b, c, d, e, f, g);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T6, T7, R> par<T1, T2, T3, T4, T5, T6, T7, R>(Func<T1, T2, T3, T4, T5, T6, T7, R> func, T1 a, T2 b, T3 c, T4 d, T5 e) =>
            (T6 f, T7 g) => func(a, b, c, d, e, f, g);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T5, T6, T7, R> par<T1, T2, T3, T4, T5, T6, T7, R>(Func<T1, T2, T3, T4, T5, T6, T7, R> func, T1 a, T2 b, T3 c, T4 d) =>
            (T5 e, T6 f, T7 g) => func(a, b, c, d, e, f, g);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T4, T5, T6, T7, R> par<T1, T2, T3, T4, T5, T6, T7, R>(Func<T1, T2, T3, T4, T5, T6, T7, R> func, T1 a, T2 b, T3 c) =>
            (T4 d, T5 e, T6 f, T7 g) => func(a, b, c, d, e, f, g);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T3, T4, T5, T6, T7, R> par<T1, T2, T3, T4, T5, T6, T7, R>(Func<T1, T2, T3, T4, T5, T6, T7, R> func, T1 a, T2 b) =>
            (T3 c, T4 d, T5 e, T6 f, T7 g) => func(a, b, c, d, e, f, g);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T2, T3, T4, T5, T6, T7, R> par<T1, T2, T3, T4, T5, T6, T7, R>(Func<T1, T2, T3, T4, T5, T6, T7, R> func, T1 a) =>
            (T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) => func(a, b, c, d, e, f, g);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T2, T3, T4, T5, T6, T7, T8, R> par<T1, T2, T3, T4, T5, T6, T7, T8, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func, T1 a) =>
            (T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) => func(a, b, c, d, e, f, g, h);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T3, T4, T5, T6, T7, T8, R> par<T1, T2, T3, T4, T5, T6, T7, T8, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func, T1 a, T2 b) =>
            (T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) => func(a, b, c, d, e, f, g, h);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T4, T5, T6, T7, T8, R> par<T1, T2, T3, T4, T5, T6, T7, T8, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func, T1 a, T2 b, T3 c) =>
            (T4 d, T5 e, T6 f, T7 g, T8 h) => func(a, b, c, d, e, f, g, h);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T5, T6, T7, T8, R> par<T1, T2, T3, T4, T5, T6, T7, T8, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func, T1 a, T2 b, T3 c, T4 d) =>
            (T5 e, T6 f, T7 g, T8 h) => func(a, b, c, d, e, f, g, h);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T6, T7, T8, R> par<T1, T2, T3, T4, T5, T6, T7, T8, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func, T1 a, T2 b, T3 c, T4 d, T5 e) =>
            (T6 f, T7 g, T8 h) => func(a, b, c, d, e, f, g, h);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T7, T8, R> par<T1, T2, T3, T4, T5, T6, T7, T8, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) =>
            (T7 g, T8 h) => func(a, b, c, d, e, f, g, h);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T8, R> par<T1, T2, T3, T4, T5, T6, T7, T8, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) =>
            (T8 h) => func(a, b, c, d, e, f, g, h);


        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> func, T1 a) =>
            (T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i) => func(a, b, c, d, e, f, g, h, i);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T3, T4, T5, T6, T7, T8, T9, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> func, T1 a, T2 b) =>
            (T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i) => func(a, b, c, d, e, f, g, h, i);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T4, T5, T6, T7, T8, T9, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> func, T1 a, T2 b, T3 c) =>
            (T4 d, T5 e, T6 f, T7 g, T8 h, T9 i) => func(a, b, c, d, e, f, g, h, i);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T5, T6, T7, T8, T9, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> func, T1 a, T2 b, T3 c, T4 d) =>
            (T5 e, T6 f, T7 g, T8 h, T9 i) => func(a, b, c, d, e, f, g, h, i);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T6, T7, T8, T9, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> func, T1 a, T2 b, T3 c, T4 d, T5 e) =>
            (T6 f, T7 g, T8 h, T9 i) => func(a, b, c, d, e, f, g, h, i);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T7, T8, T9, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) =>
            (T7 g, T8 h, T9 i) => func(a, b, c, d, e, f, g, h, i);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T8, T9, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) =>
            (T8 h, T9 i) => func(a, b, c, d, e, f, g, h, i);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T9, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) =>
            (T9 i) => func(a, b, c, d, e, f, g, h, i);


        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func, T1 a) =>
            (T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j) => func(a, b, c, d, e, f, g, h, i, j);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func, T1 a, T2 b) =>
            (T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j) => func(a, b, c, d, e, f, g, h, i, j);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T4, T5, T6, T7, T8, T9, T10, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func, T1 a, T2 b, T3 c) =>
            (T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j) => func(a, b, c, d, e, f, g, h, i, j);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T5, T6, T7, T8, T9, T10, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func, T1 a, T2 b, T3 c, T4 d) =>
            (T5 e, T6 f, T7 g, T8 h, T9 i, T10 j) => func(a, b, c, d, e, f, g, h, i, j);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T6, T7, T8, T9, T10, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func, T1 a, T2 b, T3 c, T4 d, T5 e) =>
            (T6 f, T7 g, T8 h, T9 i, T10 j) => func(a, b, c, d, e, f, g, h, i, j);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T7, T8, T9, T10, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) =>
            (T7 g, T8 h, T9 i, T10 j) => func(a, b, c, d, e, f, g, h, i, j);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T8, T9, T10, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) =>
            (T8 h, T9 i, T10 j) => func(a, b, c, d, e, f, g, h, i, j);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T9, T10, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) =>
            (T9 i, T10 j) => func(a, b, c, d, e, f, g, h, i, j);

        /// <summary>
        /// Partially apply 
        /// </summary>
        public static Func<T10, R> par<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i) =>
            (T10 j) => func(a, b, c, d, e, f, g, h, i, j);

    }
}
