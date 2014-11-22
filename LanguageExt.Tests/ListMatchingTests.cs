﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using LanguageExt;
using LanguageExt.Prelude;

namespace LanguageExtTests
{
    [TestFixture]
    public class ListMatchingTests
    {
        [Test]
        public void RecursiveMatchSumTest()
        {
            var list0 = list<int>();
            var list1 = list(10);
            var list5 = list(10,20,30,40,50);

            Assert.IsTrue(Sum(list0) == 0);
            Assert.IsTrue(Sum(list1) == 10);
            Assert.IsTrue(Sum(list5) == 150);
        }

        [Test]
        public void RecursiveMatchProductTest()
        {
            var list0 = list<int>();
            var list1 = list(10);
            var list5 = list(10, 20, 30, 40, 50);

            Assert.IsTrue(Product(list0) == 0);
            Assert.IsTrue(Product(list1) == 10);
            Assert.IsTrue(Product(list5) == 12000000);
        }

        [Test]
        public void Match6Fluent()
        {
            IEnumerable<int> listN = null;
            var list0 = list<int>();
            var list1 = list(10);
            var list2 = list(10, 20);
            var list3 = list(10, 20, 30);
            var list4 = list(10, 20, 30, 40);
            var list5 = list(10, 20, 30, 40, 50);
            var list6 = list(10, 20, 30, 40, 50, 60);
            var list100 = range(1, 100);

            var matcher = fun( (IEnumerable<int> lst) =>
               lst.Match(
                   () => 0,
                   x => 1,
                   (x, xx) => 2,
                   (x, xx, xs) => 3,
                   (x, xx, xxx, xs) => 4,
                   (x, xx, xxx, xxxx, xs) => 5,
                   (x, xx, xxx, xxxx, xxxxx, xs) => 6,
                   (x, xs) => xs.Count() + 1
               ) );

            Assert.IsTrue(matcher(listN) == 0);
            Assert.IsTrue(matcher(list0) == 0);
            Assert.IsTrue(matcher(list1) == 1);
            Assert.IsTrue(matcher(list2) == 2);
            Assert.IsTrue(matcher(list3) == 3);
            Assert.IsTrue(matcher(list4) == 4);
            Assert.IsTrue(matcher(list5) == 5);
            Assert.IsTrue(matcher(list6) == 6);
            Assert.IsTrue(matcher(list100) == 100);
        }

        [Test]
        public void Match6Func()
        {
            IEnumerable<int> listN = null;
            var list0 = list<int>();
            var list1 = list(10);
            var list2 = list(10, 20);
            var list3 = list(10, 20, 30);
            var list4 = list(10, 20, 30, 40);
            var list5 = list(10, 20, 30, 40, 50);
            var list6 = list(10, 20, 30, 40, 50, 60);
            var list100 = range(1, 100);

            var matcher = fun((IEnumerable<int> lst) =>
              match(
                  lst,
                  () => 0,
                  x => 1,
                  (x, xx) => 2,
                  (x, xx, xs) => 3,
                  (x, xx, xxx, xs) => 4,
                  (x, xx, xxx, xxxx, xs) => 5,
                  (x, xx, xxx, xxxx, xxxxx, xs) => 6,
                  (x, xs) => xs.Count() + 1
              ));

            Assert.IsTrue(matcher(listN) == 0);
            Assert.IsTrue(matcher(list0) == 0);
            Assert.IsTrue(matcher(list1) == 1);
            Assert.IsTrue(matcher(list2) == 2);
            Assert.IsTrue(matcher(list3) == 3);
            Assert.IsTrue(matcher(list4) == 4);
            Assert.IsTrue(matcher(list5) == 5);
            Assert.IsTrue(matcher(list6) == 6);
            Assert.IsTrue(matcher(list100) == 100);
        }

        public int Sum(IEnumerable<int> list) =>
            match( list,
                   ()      => 0,
                   x       => x,
                   (x, xs) => x + Sum(xs) );

        public int Product(IEnumerable<int> list) =>
            list.Match(
                () => 0,
                x => x,
                (x, xs) => x * Product(xs));

    }
}
