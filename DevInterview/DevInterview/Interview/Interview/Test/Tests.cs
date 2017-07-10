using System.Diagnostics;
using System.Linq;
using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Interview.Test
{
    [TestFixture]
    public class Tests 
    {
        public IRepository<IStoreable> repository = null;
        public IStoreable storeable = null;
        public List<int> collection = new List<int>() { 101, 102, 103, 104, 105 };

        [TestFixtureSetUp]
        public void Init()
        {
            repository = new Repository<IStoreable>();
            storeable = new Storeable();
        }

        protected void Save(int? id)
        {
            storeable.Id = id;
            repository.Save(storeable);
        }

        protected void SaveAll( List<int> collection)
        {
            foreach (var id in collection)
            {
                storeable = new Storeable();
                storeable.Id = id;
                repository.Save(storeable);
            }
        }

        protected int ItemCount()
        {
            return repository.All().Count();
        }


        [TestFixtureTearDown]
        public void Close()
        {
            if (repository != null)
                repository = null;

            if (storeable != null)
                storeable = null;
        }

    }

}