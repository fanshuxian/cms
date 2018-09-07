﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.Cli.Core;
using SiteServer.Cli.Updater.Plugins.GovInteract;
using SiteServer.Cli.Updater.Plugins.GovPublic;
using SiteServer.Cli.Updater.Plugins.Jobs;
using SiteServer.CMS.Core;
using SiteServer.Plugin;
using TableInfo = SiteServer.CMS.Model.TableInfo;

namespace SiteServer.Cli.Updater.Model3
{
    public partial class TableTable
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("tableENName")]
        public string TableEnName { get; set; }

        [JsonProperty("tableCNName")]
        public string TableCnName { get; set; }

        [JsonProperty("attributeNum")]
        public long AttributeNum { get; set; }

        [JsonProperty("auxiliaryTableType")]
        public string AuxiliaryTableType { get; set; }

        [JsonProperty("isCreatedInDB")]
        public string IsCreatedInDb { get; set; }

        [JsonProperty("isChangedAfterCreatedInDB")]
        public string IsChangedAfterCreatedInDb { get; set; }

        [JsonProperty("productID")]
        public string ProductId { get; set; }

        [JsonProperty("isDefault")]
        public string IsDefault { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class TableTable
    {
        public const string OldTableName = "bairong_TableCollection";

        public static ConvertInfo Converter => new ConvertInfo
        {
            NewTableName = NewTableName,
            NewColumns = NewColumns,
            ConvertKeyDict = ConvertKeyDict
        };

        private static readonly string NewTableName = DataProvider.TableDao.TableName;

        private static readonly List<TableColumn> NewColumns = DataProvider.TableDao.TableColumns;

        private static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {nameof(TableInfo.TableName), nameof(TableEnName)},
                {nameof(TableInfo.DisplayName), nameof(TableCnName)}
            };
    }
}