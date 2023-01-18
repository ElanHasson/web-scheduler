﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebScheduler.DataMigrations;

#nullable disable

namespace WebScheduler.DataMigrations.Migrations
{
    [DbContext(typeof(OrleansDbContext))]
    partial class OrleansDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebScheduler.DataMigrations.OrleansMembershipTable", b =>
                {
                    b.Property<string>("DeploymentId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("DeploymentId"), "utf8");

                    b.Property<string>("Address")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<int>("Port")
                        .HasColumnType("int");

                    b.Property<int>("Generation")
                        .HasColumnType("int");

                    b.Property<string>("HostName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("HostName"), "utf8");

                    b.Property<DateTime>("IamAliveTime")
                        .HasColumnType("datetime")
                        .HasColumnName("IAmAliveTime");

                    b.Property<int?>("ProxyPort")
                        .HasColumnType("int");

                    b.Property<string>("SiloName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("SiloName"), "utf8");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("SuspectTimes")
                        .HasMaxLength(8000)
                        .HasColumnType("varchar(8000)");

                    b.HasKey("DeploymentId", "Address", "Port", "Generation")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                    b.ToTable("OrleansMembershipTable", (string)null);
                });

            modelBuilder.Entity("WebScheduler.DataMigrations.OrleansMembershipVersionTable", b =>
                {
                    b.Property<string>("DeploymentId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("DeploymentId"), "utf8");

                    b.Property<DateTime?>("Timestamp")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("DeploymentId")
                        .HasName("PRIMARY");

                    b.ToTable("OrleansMembershipVersionTable", (string)null);
                });

            modelBuilder.Entity("WebScheduler.DataMigrations.OrleansQuery", b =>
                {
                    b.Property<string>("QueryKey")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("QueryText")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("varchar(8000)");

                    b.HasKey("QueryKey")
                        .HasName("PRIMARY");

                    b.ToTable("OrleansQuery", (string)null);
                });

            modelBuilder.Entity("WebScheduler.DataMigrations.OrleansRemindersTable", b =>
                {
                    b.Property<string>("ServiceId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("ServiceId"), "utf8");

                    b.Property<string>("GrainId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ReminderName")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("ReminderName"), "utf8");

                    b.Property<int>("GrainHash")
                        .HasColumnType("int");

                    b.Property<long>("Period")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("ServiceId", "GrainId", "ReminderName")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                    b.ToTable("OrleansRemindersTable", (string)null);
                });

            modelBuilder.Entity("WebScheduler.DataMigrations.OrleansStorage", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GrainIdHash")
                        .HasColumnType("int");

                    b.Property<int>("GrainTypeHash")
                        .HasColumnType("int");

                    b.Property<string>("GrainIdExtensionString")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("GrainIdExtensionString"), "utf8");

                    b.Property<long>("GrainIdN0")
                        .HasColumnType("bigint");

                    b.Property<long>("GrainIdN1")
                        .HasColumnType("bigint");

                    b.Property<string>("GrainTypeString")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("GrainTypeString"), "utf8");

                    b.Property<ulong?>("IsScheduledTaskDeleted")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bit")
                        .HasComputedColumnSql("CASE WHEN GrainTypeHash = 2108290596 THEN\r\n    CASE WHEN JSON_EXTRACT(PayloadJson, \"$.isDeleted\") IS NOT NULL THEN \r\n        true\r\n    ELSE \r\n        false\r\n    END \r\nEND", true);

                    b.Property<ulong?>("IsScheduledTaskEnabled")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bit")
                        .HasComputedColumnSql("CASE WHEN GrainTypeHash = 2108290596 THEN\r\n    CASE WHEN JSON_EXTRACT(PayloadJson, \"$.task.isEnabled\") IS NOT NULL THEN \r\n        true\r\n    ELSE \r\n        false\r\n    END \r\nEND", true);

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("PayloadBinary")
                        .HasColumnType("blob");

                    b.Property<string>("PayloadJson")
                        .HasColumnType("json");

                    b.Property<string>("PayloadXml")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceId")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("ServiceId"), "utf8");

                    b.Property<string>("TenantId")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComputedColumnSql("CASE WHEN GrainTypeHash = 2108290596 THEN\r\n    CASE WHEN JSON_UNQUOTE(JSON_EXTRACT(PayloadJson, \"$.tenantId\")) IS NOT NULL THEN \r\n        JSON_UNQUOTE(JSON_EXTRACT(PayloadJson, \"$.tenantId\"))\r\n    ELSE \r\n        JSON_UNQUOTE(JSON_EXTRACT(PayloadJson, \"$.tenantIdString\"))\r\n    END \r\nEND", true)
                        .UseCollation("utf8_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("TenantId"), "utf8");

                    b.Property<int?>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id", "GrainIdHash", "GrainTypeHash")
                        .HasName("PRIMARY");

                    b.HasIndex("IsScheduledTaskDeleted")
                        .HasDatabaseName("IX_OrleansStorage_ScheduledTaskState_IsScheduledTaskDeleted");

                    b.HasIndex("IsScheduledTaskEnabled")
                        .HasDatabaseName("IX_OrleansStorage_ScheduledTaskState_IsScheduledTaskEnabled");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("IX_OrleansStorage_ScheduledTaskState_TenantId");

                    b.HasIndex("GrainIdHash", "GrainTypeHash")
                        .HasDatabaseName("IX_OrleansStorage");

                    b.ToTable("OrleansStorage", (string)null);
                });

            modelBuilder.Entity("WebScheduler.DataMigrations.OrleansMembershipTable", b =>
                {
                    b.HasOne("WebScheduler.DataMigrations.OrleansMembershipVersionTable", "Deployment")
                        .WithMany("OrleansMembershipTables")
                        .HasForeignKey("DeploymentId")
                        .IsRequired()
                        .HasConstraintName("FK_MembershipTable_MembershipVersionTable_DeploymentId");

                    b.Navigation("Deployment");
                });

            modelBuilder.Entity("WebScheduler.DataMigrations.OrleansMembershipVersionTable", b =>
                {
                    b.Navigation("OrleansMembershipTables");
                });
#pragma warning restore 612, 618
        }
    }
}
