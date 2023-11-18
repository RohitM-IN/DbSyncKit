﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync.DB.Interface
{
    public interface IMetadata
    {
        ICollection<T> GetTables<T>();

        ICollection<T> GetColumns<T>();

        ICollection<T> GetColumns<T>(string tableName);

        ICollection<T> GetIndex<T>();

        ICollection<T> GetPrimary<T>();

        ICollection<T> GetForeign<T>();

        ICollection<T> GetIdentity<T>();

        ICollection<T> GetUniqueConstraint<T>();

        ICollection<T> GetDefaultConstraint<T>();

        ICollection<T> GetCheckConstraint<T>();

        ICollection<T> GetUserDataType<T>();

        ICollection<T> GetUserTableType<T>();
    }
}