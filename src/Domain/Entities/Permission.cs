﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Permission : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<GroupRolePermission> RolePermissions { get; set; }

    }
}
