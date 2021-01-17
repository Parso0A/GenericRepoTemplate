using GenericTestDataAccess;
using GenericTestDomain.Model;
using GenericTestDomain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTestService
{
    public class UnitOfWork
    {
        public UnitOfWork()
        {

        }
        public virtual IGenericTestRepository<T> GenericTestRepository<T>() where T : EntityType
        {
            var type = typeof(T).Name;
            var repoType = typeof(GenericTestRepository<>);
            return (IGenericTestRepository<T>)Activator.CreateInstance(repoType.MakeGenericType(typeof(T)));
        }
    }
}
