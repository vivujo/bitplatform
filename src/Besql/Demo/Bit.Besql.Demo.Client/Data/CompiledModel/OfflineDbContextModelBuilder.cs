﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Bit.Besql.Demo.Client.Data.CompiledModel
{
    public partial class OfflineDbContextModel
    {
        partial void Initialize()
        {
            var weatherForecast = WeatherForecastEntityType.Create(this);

            WeatherForecastEntityType.CreateAnnotations(weatherForecast);

            AddAnnotation("ProductVersion", "8.0.0");
            AddRuntimeAnnotation("Relational:RelationalModel", CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);

            var weatherForecast = FindEntityType("Bit.Besql.Demo.Client.Model.WeatherForecast")!;

            var defaultTableMappings = new List<TableMappingBase<ColumnMappingBase>>();
            weatherForecast.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings);
            var bitBesqlSampleClientModelWeatherForecastTableBase = new TableBase("Bit.Besql.Demo.Client.Model.WeatherForecast", null, relationalModel);
            var dateColumnBase = new ColumnBase<ColumnMappingBase>("Date", "INTEGER", bitBesqlSampleClientModelWeatherForecastTableBase);
            bitBesqlSampleClientModelWeatherForecastTableBase.Columns.Add("Date", dateColumnBase);
            var idColumnBase = new ColumnBase<ColumnMappingBase>("Id", "INTEGER", bitBesqlSampleClientModelWeatherForecastTableBase);
            bitBesqlSampleClientModelWeatherForecastTableBase.Columns.Add("Id", idColumnBase);
            var summaryColumnBase = new ColumnBase<ColumnMappingBase>("Summary", "TEXT", bitBesqlSampleClientModelWeatherForecastTableBase)
            {
                IsNullable = true
            };
            bitBesqlSampleClientModelWeatherForecastTableBase.Columns.Add("Summary", summaryColumnBase);
            var temperatureCColumnBase = new ColumnBase<ColumnMappingBase>("TemperatureC", "INTEGER", bitBesqlSampleClientModelWeatherForecastTableBase);
            bitBesqlSampleClientModelWeatherForecastTableBase.Columns.Add("TemperatureC", temperatureCColumnBase);
            relationalModel.DefaultTables.Add("Bit.Besql.Demo.Client.Model.WeatherForecast", bitBesqlSampleClientModelWeatherForecastTableBase);
            var bitBesqlSampleClientModelWeatherForecastMappingBase = new TableMappingBase<ColumnMappingBase>(weatherForecast, bitBesqlSampleClientModelWeatherForecastTableBase, true);
            bitBesqlSampleClientModelWeatherForecastTableBase.AddTypeMapping(bitBesqlSampleClientModelWeatherForecastMappingBase, false);
            defaultTableMappings.Add(bitBesqlSampleClientModelWeatherForecastMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)idColumnBase, weatherForecast.FindProperty("Id")!, bitBesqlSampleClientModelWeatherForecastMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)dateColumnBase, weatherForecast.FindProperty("Date")!, bitBesqlSampleClientModelWeatherForecastMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)summaryColumnBase, weatherForecast.FindProperty("Summary")!, bitBesqlSampleClientModelWeatherForecastMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)temperatureCColumnBase, weatherForecast.FindProperty("TemperatureC")!, bitBesqlSampleClientModelWeatherForecastMappingBase);

            var tableMappings = new List<TableMapping>();
            weatherForecast.SetRuntimeAnnotation("Relational:TableMappings", tableMappings);
            var weatherForecastsTable = new Table("WeatherForecasts", null, relationalModel);
            var idColumn = new Column("Id", "INTEGER", weatherForecastsTable);
            weatherForecastsTable.Columns.Add("Id", idColumn);
            var dateColumn = new Column("Date", "INTEGER", weatherForecastsTable);
            weatherForecastsTable.Columns.Add("Date", dateColumn);
            var summaryColumn = new Column("Summary", "TEXT", weatherForecastsTable)
            {
                IsNullable = true
            };
            weatherForecastsTable.Columns.Add("Summary", summaryColumn);
            var temperatureCColumn = new Column("TemperatureC", "INTEGER", weatherForecastsTable);
            weatherForecastsTable.Columns.Add("TemperatureC", temperatureCColumn);
            var pK_WeatherForecasts = new UniqueConstraint("PK_WeatherForecasts", weatherForecastsTable, new[] { idColumn });
            weatherForecastsTable.PrimaryKey = pK_WeatherForecasts;
            var pK_WeatherForecastsUc = RelationalModel.GetKey(this,
                "Bit.Besql.Demo.Client.Model.WeatherForecast",
                new[] { "Id" });
            pK_WeatherForecasts.MappedKeys.Add(pK_WeatherForecastsUc);
            RelationalModel.GetOrCreateUniqueConstraints(pK_WeatherForecastsUc).Add(pK_WeatherForecasts);
            weatherForecastsTable.UniqueConstraints.Add("PK_WeatherForecasts", pK_WeatherForecasts);
            var iX_WeatherForecasts_TemperatureC = new TableIndex(
            "IX_WeatherForecasts_TemperatureC", weatherForecastsTable, new[] { temperatureCColumn }, false);
            var iX_WeatherForecasts_TemperatureCIx = RelationalModel.GetIndex(this,
                "Bit.Besql.Demo.Client.Model.WeatherForecast",
                new[] { "TemperatureC" });
            iX_WeatherForecasts_TemperatureC.MappedIndexes.Add(iX_WeatherForecasts_TemperatureCIx);
            RelationalModel.GetOrCreateTableIndexes(iX_WeatherForecasts_TemperatureCIx).Add(iX_WeatherForecasts_TemperatureC);
            weatherForecastsTable.Indexes.Add("IX_WeatherForecasts_TemperatureC", iX_WeatherForecasts_TemperatureC);
            relationalModel.Tables.Add(("WeatherForecasts", null), weatherForecastsTable);
            var weatherForecastsTableMapping = new TableMapping(weatherForecast, weatherForecastsTable, true);
            weatherForecastsTable.AddTypeMapping(weatherForecastsTableMapping, false);
            tableMappings.Add(weatherForecastsTableMapping);
            RelationalModel.CreateColumnMapping(idColumn, weatherForecast.FindProperty("Id")!, weatherForecastsTableMapping);
            RelationalModel.CreateColumnMapping(dateColumn, weatherForecast.FindProperty("Date")!, weatherForecastsTableMapping);
            RelationalModel.CreateColumnMapping(summaryColumn, weatherForecast.FindProperty("Summary")!, weatherForecastsTableMapping);
            RelationalModel.CreateColumnMapping(temperatureCColumn, weatherForecast.FindProperty("TemperatureC")!, weatherForecastsTableMapping);
            return relationalModel.MakeReadOnly();
        }
    }
}
