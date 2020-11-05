﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OracleCOEWorkTracking.Data;
using System;

namespace OracleCOEWorkTracking.Data.Migrations
{
    [DbContext(typeof(WorkTrackingContext))]
    [Migration("20190930203436_attachmentfix2")]
    partial class attachmentfix2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.BooleanDropDown", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("BooleanDropDownValues");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.DevelopmentTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DevelopmentTeams");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.Environment", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Environment");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.Gate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Gates");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.GateStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("GateStatuses");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.ImpactedStream", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ImpactedStreams");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.OraclePreProdEnvironment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OraclePreProdEnvironments");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.OwningSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OwningSites");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.OwningStream", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<string>("dlEmailAddress");

                    b.HasKey("Id");

                    b.ToTable("OwningStreams");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attribute1");

                    b.Property<DateTime?>("Attribute10");

                    b.Property<string>("Attribute2");

                    b.Property<string>("Attribute3");

                    b.Property<string>("Attribute4");

                    b.Property<string>("Attribute5");

                    b.Property<string>("Attribute6");

                    b.Property<string>("Attribute7");

                    b.Property<string>("Attribute8");

                    b.Property<string>("Attribute9");

                    b.Property<string>("BIContact");

                    b.Property<string>("BIGateQuestionnaireUrl");

                    b.Property<int?>("BIGateStatusId");

                    b.Property<int?>("BIRequestId");

                    b.Property<string>("BenefitCase");

                    b.Property<int?>("COEPriority");

                    b.Property<int?>("CRNo");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DCOEDevelopmentLead");

                    b.Property<double?>("DCOEEstimate");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("EBSGateQuestionnaireUrl");

                    b.Property<int?>("EBSGateStatusId");

                    b.Property<int?>("EstimateInfra");

                    b.Property<string>("FrontLineContact");

                    b.Property<string>("FunctionalContact");

                    b.Property<int?>("GBSPriority");

                    b.Property<string>("MD_50");

                    b.Property<DateTime?>("MD_50_DueDate");

                    b.Property<string>("MD_70");

                    b.Property<DateTime?>("MD_70_DueDate");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int?>("NextBIGateId");

                    b.Property<int?>("NextEBSGateId");

                    b.Property<int?>("Next_NETGateId");

                    b.Property<int?>("OTMEBSGateId");

                    b.Property<string>("OTMGateQuestionnaireUrl");

                    b.Property<int?>("OTMGateStatusId");

                    b.Property<double?>("OracleDevEstimateOffShore");

                    b.Property<double?>("OracleDevEstimateOnShore");

                    b.Property<string>("OracleDevelopmentLead");

                    b.Property<string>("OriginalSystemReference");

                    b.Property<int?>("OwningSiteId");

                    b.Property<int>("OwningStreamId");

                    b.Property<string>("Problem");

                    b.Property<DateTime?>("ProductionDate");

                    b.Property<string>("ProjectName");

                    b.Property<int?>("ReadyForBIGateId");

                    b.Property<int?>("ReadyForEBSGateId");

                    b.Property<int?>("ReadyForOTMGateId");

                    b.Property<int?>("ReadyFor_NETGateId");

                    b.Property<string>("Requestor");

                    b.Property<int>("StatusId");

                    b.Property<string>("TIPUrl");

                    b.Property<DateTime?>("TestingDate");

                    b.Property<double?>("TotalEstimate");

                    b.Property<string>("_NETGateQuestionnaireUrl");

                    b.Property<int?>("_NETGateStatusId");

                    b.HasKey("Id");

                    b.HasIndex("BIGateStatusId");

                    b.HasIndex("BIRequestId");

                    b.HasIndex("EBSGateStatusId");

                    b.HasIndex("NextBIGateId");

                    b.HasIndex("NextEBSGateId");

                    b.HasIndex("Next_NETGateId");

                    b.HasIndex("OTMEBSGateId");

                    b.HasIndex("OTMGateStatusId");

                    b.HasIndex("OwningSiteId");

                    b.HasIndex("OwningStreamId");

                    b.HasIndex("ReadyForBIGateId");

                    b.HasIndex("ReadyForEBSGateId");

                    b.HasIndex("ReadyForOTMGateId");

                    b.HasIndex("ReadyFor_NETGateId");

                    b.HasIndex("StatusId");

                    b.HasIndex("_NETGateStatusId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestAttachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Attachment");

                    b.Property<string>("FileName");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestAttachments");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestDevelopmentTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DevelopmentTeamId");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("DevelopmentTeamId");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestDevelopmentTeams");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestImpactedStream", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ImpactedStreamId");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("ImpactedStreamId");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestImpactedStreams");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ModuleId");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestModules");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Note");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestNotes");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestOraclePreProdEnvironment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OraclePreProdEnvironmentId");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("OraclePreProdEnvironmentId");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestOraclePreProdEnvironments");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RegionId");

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.HasIndex("RequestId");

                    b.ToTable("RequestRegions");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestSBU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RequestId");

                    b.Property<int>("SBUId");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.HasIndex("SBUId");

                    b.ToTable("RequestSBUs");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Attachments");

                    b.Property<bool>("Attribute1");

                    b.Property<bool>("Attribute10");

                    b.Property<bool>("Attribute2");

                    b.Property<bool>("Attribute3");

                    b.Property<bool>("Attribute4");

                    b.Property<bool>("Attribute5");

                    b.Property<bool>("Attribute6");

                    b.Property<bool>("Attribute7");

                    b.Property<bool>("Attribute8");

                    b.Property<bool>("Attribute9");

                    b.Property<bool>("BIContact");

                    b.Property<bool>("BIGateQuestionaireUrl");

                    b.Property<bool>("BIGateStatus");

                    b.Property<bool>("BIRequest");

                    b.Property<bool>("BenefitCase");

                    b.Property<bool>("COEPriority");

                    b.Property<bool>("CRNo");

                    b.Property<bool>("CreatedBy");

                    b.Property<bool>("CreatedOn");

                    b.Property<bool>("DCOEDevelopmentLead");

                    b.Property<bool>("DCOEEstimate");

                    b.Property<bool>("DevelopmentTeams");

                    b.Property<bool>("EBSGateQuestionaireUrl");

                    b.Property<bool>("EBSGateStatus");

                    b.Property<bool>("EstimateInfra");

                    b.Property<bool>("FrontLineContact");

                    b.Property<bool>("FunctionalContact");

                    b.Property<bool>("GBSPriority");

                    b.Property<bool>("ImpactedStreams");

                    b.Property<bool>("MD_50");

                    b.Property<bool>("MD_50_DueDate");

                    b.Property<bool>("MD_70");

                    b.Property<bool>("MD_70_DueDate");

                    b.Property<bool>("ModifiedBy");

                    b.Property<bool>("ModifiedOn");

                    b.Property<bool>("Modules");

                    b.Property<string>("Name");

                    b.Property<bool>("NextBIGate");

                    b.Property<bool>("NextEBSGate");

                    b.Property<bool>("Next_NETGate");

                    b.Property<bool>("Notes");

                    b.Property<bool>("OTMEBSGate");

                    b.Property<bool>("OTMGateQuestionaireUrl");

                    b.Property<bool>("OTMGateStatus");

                    b.Property<bool>("OracleDevEstimateOffShore");

                    b.Property<bool>("OracleDevEstimateOnShore");

                    b.Property<bool>("OracleDevelopmentLead");

                    b.Property<bool>("OraclePreProdEnvironments");

                    b.Property<string>("OrderBy");

                    b.Property<bool>("OriginalSystemReference");

                    b.Property<bool>("OwningSite");

                    b.Property<bool>("OwningStream");

                    b.Property<bool>("Problem");

                    b.Property<bool>("ProductionDate");

                    b.Property<bool>("ProjectName");

                    b.Property<bool>("ReadyForBIGate");

                    b.Property<bool>("ReadyForEBSGate");

                    b.Property<bool>("ReadyForOTMGate");

                    b.Property<bool>("ReadyFor_NETGate");

                    b.Property<bool>("Regions");

                    b.Property<bool>("Requestor");

                    b.Property<bool>("SBUs");

                    b.Property<bool>("Status");

                    b.Property<bool>("TIPUrl");

                    b.Property<bool>("TestingDate");

                    b.Property<bool>("TotalEstimate");

                    b.Property<string>("WhereClaus");

                    b.Property<bool>("_NETGateQuestionaireUrl");

                    b.Property<bool>("_NETGateStatus");

                    b.HasKey("Id");

                    b.ToTable("RequestViews");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.SBU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SBUs");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("DeleteMark");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.Request", b =>
                {
                    b.HasOne("OracleCOEWorkTracking.Data.Entities.GateStatus", "BIGateStatus")
                        .WithMany()
                        .HasForeignKey("BIGateStatusId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.BooleanDropDown", "BIRequest")
                        .WithMany()
                        .HasForeignKey("BIRequestId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.GateStatus", "EBSGateStatus")
                        .WithMany()
                        .HasForeignKey("EBSGateStatusId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Gate", "NextBIGate")
                        .WithMany()
                        .HasForeignKey("NextBIGateId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Gate", "NextEBSGate")
                        .WithMany()
                        .HasForeignKey("NextEBSGateId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Gate", "Next_NETGate")
                        .WithMany()
                        .HasForeignKey("Next_NETGateId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Gate", "OTMEBSGate")
                        .WithMany()
                        .HasForeignKey("OTMEBSGateId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.GateStatus", "OTMGateStatus")
                        .WithMany()
                        .HasForeignKey("OTMGateStatusId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.OwningSite", "OwningSite")
                        .WithMany()
                        .HasForeignKey("OwningSiteId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.OwningStream", "OwningStream")
                        .WithMany()
                        .HasForeignKey("OwningStreamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.BooleanDropDown", "ReadyForBIGate")
                        .WithMany()
                        .HasForeignKey("ReadyForBIGateId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.BooleanDropDown", "ReadyForEBSGate")
                        .WithMany()
                        .HasForeignKey("ReadyForEBSGateId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.BooleanDropDown", "ReadyForOTMGate")
                        .WithMany()
                        .HasForeignKey("ReadyForOTMGateId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.BooleanDropDown", "ReadyFor_NETGate")
                        .WithMany()
                        .HasForeignKey("ReadyFor_NETGateId");

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.GateStatus", "_NETGateStatus")
                        .WithMany()
                        .HasForeignKey("_NETGateStatusId");
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestAttachment", b =>
                {
                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Request")
                        .WithMany("Attachments")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestDevelopmentTeam", b =>
                {
                    b.HasOne("OracleCOEWorkTracking.Data.Entities.DevelopmentTeam", "DevelopmentTeam")
                        .WithMany()
                        .HasForeignKey("DevelopmentTeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Request")
                        .WithMany("DevelopmentTeams")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestImpactedStream", b =>
                {
                    b.HasOne("OracleCOEWorkTracking.Data.Entities.ImpactedStream", "ImpactedStream")
                        .WithMany()
                        .HasForeignKey("ImpactedStreamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Request")
                        .WithMany("ImpactedStreams")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestModule", b =>
                {
                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Request")
                        .WithMany("Modules")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestNote", b =>
                {
                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Request")
                        .WithMany("Notes")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestOraclePreProdEnvironment", b =>
                {
                    b.HasOne("OracleCOEWorkTracking.Data.Entities.OraclePreProdEnvironment", "OraclePreProdEnvironment")
                        .WithMany()
                        .HasForeignKey("OraclePreProdEnvironmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Request")
                        .WithMany("OraclePreProdEnvironments")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestRegion", b =>
                {
                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Request")
                        .WithMany("Regions")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OracleCOEWorkTracking.Data.Entities.RequestSBU", b =>
                {
                    b.HasOne("OracleCOEWorkTracking.Data.Entities.Request")
                        .WithMany("SBUs")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OracleCOEWorkTracking.Data.Entities.SBU", "SBU")
                        .WithMany()
                        .HasForeignKey("SBUId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
