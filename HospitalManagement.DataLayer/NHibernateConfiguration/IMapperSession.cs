using HospitalManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalManagement.DataLayer.NHibernateConfiguration
{
    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(Patient entity);
        System.Threading.Tasks.Task Delete(Patient entity);
        IQueryable<Patient> patient { get; }
    }
}
