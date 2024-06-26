﻿using System;
using System.Collections.Generic;

namespace ClassIsland.ManagementServer.Server.Entities;

public partial class ClientGroup
{
    public int GroupId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<ObjectsAssignee> ObjectsAssignees { get; set; } = new List<ObjectsAssignee>();
}
