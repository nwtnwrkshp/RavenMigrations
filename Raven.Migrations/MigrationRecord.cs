﻿using System;

namespace Raven.Migrations
{
  public class MigrationRecord : IMigrationRecord
  {
    public string? Id { get; set; }
    public DateTimeOffset RunOn { get; set; } = DateTimeOffset.UtcNow;
    public long? Version { get; set; }
    public string? Description { get; set; }
  }
}