﻿using System.Collections.Generic;

namespace MasterChief.DotNet.Core.Contract
{
    /// <summary>
    /// 数据访问上下文接口
    /// </summary>
    public interface IDbContext
    {
        #region Methods

        int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters);

        IList<T> ExecuteStoredProcedureList<T>(string commandText, params object[] parameters)
            where T : ModelBase;

        int SaveChanges();

        IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters)
            where T : ModelBase;

        #endregion Methods
    }
}