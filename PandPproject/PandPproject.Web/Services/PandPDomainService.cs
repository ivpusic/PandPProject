
namespace PandPproject.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using PandPproject.Web.Models;


    // Implements application logic using the PandPdataBaseEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class PandPDomainService : LinqToEntitiesDomainService<PandPdataBaseEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Members' query.
        [Query(IsDefault = true)]
        public IQueryable<Members> GetMembers()
        {
            return this.ObjectContext.Members;
        }

        public void InsertMembers(Members members)
        {
            if ((members.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(members, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Members.AddObject(members);
            }
        }

        public void UpdateMembers(Members currentMembers)
        {
            this.ObjectContext.Members.AttachAsModified(currentMembers, this.ChangeSet.GetOriginal(currentMembers));
        }

        public void DeleteMembers(Members members)
        {
            if ((members.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(members, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Members.Attach(members);
                this.ObjectContext.Members.DeleteObject(members);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'sysdiagrams' query.
        [Query(IsDefault = true)]
        public IQueryable<sysdiagrams> GetSysdiagrams()
        {
            return this.ObjectContext.sysdiagrams;
        }

        public void InsertSysdiagrams(sysdiagrams sysdiagrams)
        {
            if ((sysdiagrams.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sysdiagrams, EntityState.Added);
            }
            else
            {
                this.ObjectContext.sysdiagrams.AddObject(sysdiagrams);
            }
        }

        public void UpdateSysdiagrams(sysdiagrams currentsysdiagrams)
        {
            this.ObjectContext.sysdiagrams.AttachAsModified(currentsysdiagrams, this.ChangeSet.GetOriginal(currentsysdiagrams));
        }

        public void DeleteSysdiagrams(sysdiagrams sysdiagrams)
        {
            if ((sysdiagrams.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sysdiagrams, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.sysdiagrams.Attach(sysdiagrams);
                this.ObjectContext.sysdiagrams.DeleteObject(sysdiagrams);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Traffic' query.
        [Query(IsDefault = true)]
        public IQueryable<Traffic> GetTraffic()
        {
            return this.ObjectContext.Traffic.OrderBy(te => te.ID);
        }

        public void InsertTraffic(Traffic traffic)
        {
            if ((traffic.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(traffic, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Traffic.AddObject(traffic);
            }
        }

        public void UpdateTraffic(Traffic currentTraffic)
        {
            this.ObjectContext.Traffic.AttachAsModified(currentTraffic, this.ChangeSet.GetOriginal(currentTraffic));
        }

        public void DeleteTraffic(Traffic traffic)
        {
            if ((traffic.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(traffic, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Traffic.Attach(traffic);
                this.ObjectContext.Traffic.DeleteObject(traffic);
            }
        }
    }
}


