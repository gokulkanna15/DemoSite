using System;
using System.Collections.Generic;

namespace Demo.Domain.Entities;

public partial class LocationDetail
{
    public string Country { get; set; } = null!;

    public string City { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
