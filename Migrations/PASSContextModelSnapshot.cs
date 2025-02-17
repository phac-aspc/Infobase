﻿// <auto-generated />
using System;
using Infobase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infobase.Migrations
{
    [DbContext(typeof(PASSContext))]
    partial class PASSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Infobase.Models.PASS.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActivityNameEn");

                    b.Property<string>("ActivityNameFr");

                    b.Property<int?>("DefaultIndicatorGroupId");

                    b.Property<int>("Index");

                    b.HasKey("ActivityId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("DefaultIndicatorGroupId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Indicator", b =>
                {
                    b.Property<int>("IndicatorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DefaultMeasureId");

                    b.Property<int>("Index");

                    b.Property<string>("IndicatorNameEn");

                    b.Property<string>("IndicatorNameFr");

                    b.Property<int>("LifeCourseId");

                    b.HasKey("IndicatorId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("DefaultMeasureId");

                    b.HasIndex("LifeCourseId");

                    b.ToTable("Indicator");
                });

            modelBuilder.Entity("Infobase.Models.PASS.IndicatorGroup", b =>
                {
                    b.Property<int>("IndicatorGroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityId");

                    b.Property<int?>("DefaultLifeCourseId");

                    b.Property<int>("Index");

                    b.Property<string>("IndicatorGroupNameEn");

                    b.Property<string>("IndicatorGroupNameFr");

                    b.HasKey("IndicatorGroupId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("ActivityId");

                    b.HasIndex("DefaultLifeCourseId");

                    b.ToTable("IndicatorGroup");
                });

            modelBuilder.Entity("Infobase.Models.PASS.LifeCourse", b =>
                {
                    b.Property<int>("LifeCourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DefaultIndicatorId");

                    b.Property<int>("Index");

                    b.Property<int>("IndicatorGroupId");

                    b.Property<string>("LifeCourseNameEn");

                    b.Property<string>("LifeCourseNameFr");

                    b.HasKey("LifeCourseId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("DefaultIndicatorId");

                    b.HasIndex("IndicatorGroupId");

                    b.ToTable("LifeCourse");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Measure", b =>
                {
                    b.Property<int>("MeasureId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Aggregator");

                    b.Property<double?>("CVSuppressAt");

                    b.Property<double?>("CVWarnAt");

                    b.Property<int?>("DefaultStrataId");

                    b.Property<bool>("Included");

                    b.Property<int>("Index");

                    b.Property<int>("IndicatorId");

                    b.Property<string>("MeasureAdditionalRemarksEn");

                    b.Property<string>("MeasureAdditionalRemarksFr");

                    b.Property<string>("MeasureDataAvailableEn");

                    b.Property<string>("MeasureDataAvailableFr");

                    b.Property<string>("MeasureDefinitionEn");

                    b.Property<string>("MeasureDefinitionFr");

                    b.Property<string>("MeasureMethodEn");

                    b.Property<string>("MeasureMethodFr");

                    b.Property<string>("MeasureNameDataToolEn");

                    b.Property<string>("MeasureNameDataToolFr");

                    b.Property<string>("MeasureNameIndexEn");

                    b.Property<string>("MeasureNameIndexFr");

                    b.Property<string>("MeasurePopulationGroupEn");

                    b.Property<string>("MeasurePopulationGroupFr");

                    b.Property<string>("MeasureSourceLongEn");

                    b.Property<string>("MeasureSourceLongFr");

                    b.Property<string>("MeasureSourceShortEn");

                    b.Property<string>("MeasureSourceShortFr");

                    b.Property<string>("MeasureUnitLongEn");

                    b.Property<string>("MeasureUnitLongFr");

                    b.Property<string>("MeasureUnitShortEn");

                    b.Property<string>("MeasureUnitShortFr");

                    b.HasKey("MeasureId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("DefaultStrataId");

                    b.HasIndex("IndicatorId");

                    b.ToTable("Measure");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Point", b =>
                {
                    b.Property<int>("PointId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CVInterpretation");

                    b.Property<int?>("CVValue");

                    b.Property<int>("Index");

                    b.Property<string>("PointLabelEn");

                    b.Property<string>("PointLabelFr");

                    b.Property<string>("PointTextEn");

                    b.Property<string>("PointTextFr");

                    b.Property<int>("StrataId");

                    b.Property<int>("Type");

                    b.Property<double?>("ValueAverage");

                    b.Property<double?>("ValueLower");

                    b.Property<double?>("ValueUpper");

                    b.HasKey("PointId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("StrataId");

                    b.ToTable("Point");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Strata", b =>
                {
                    b.Property<int>("StrataId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Index");

                    b.Property<int>("MeasureId");

                    b.Property<string>("StrataNameEn");

                    b.Property<string>("StrataNameFr");

                    b.Property<string>("StrataNotesEn");

                    b.Property<string>("StrataNotesFr");

                    b.Property<string>("StrataPopulationTitleFragmentEn");

                    b.Property<string>("StrataPopulationTitleFragmentFr");

                    b.Property<string>("StrataSourceEn");

                    b.Property<string>("StrataSourceFr");

                    b.HasKey("StrataId");

                    b.HasAlternateKey("Index");

                    b.HasIndex("MeasureId");

                    b.ToTable("Strata");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Activity", b =>
                {
                    b.HasOne("Infobase.Models.PASS.IndicatorGroup", "DefaultIndicatorGroup")
                        .WithMany()
                        .HasForeignKey("DefaultIndicatorGroupId");
                });

            modelBuilder.Entity("Infobase.Models.PASS.Indicator", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "DefaultMeasure")
                        .WithMany()
                        .HasForeignKey("DefaultMeasureId");

                    b.HasOne("Infobase.Models.PASS.LifeCourse", "LifeCourse")
                        .WithMany("Indicators")
                        .HasForeignKey("LifeCourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.IndicatorGroup", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Activity", "Activity")
                        .WithMany("IndicatorGroups")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infobase.Models.PASS.LifeCourse", "DefaultLifeCourse")
                        .WithMany()
                        .HasForeignKey("DefaultLifeCourseId");
                });

            modelBuilder.Entity("Infobase.Models.PASS.LifeCourse", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Indicator", "DefaultIndicator")
                        .WithMany()
                        .HasForeignKey("DefaultIndicatorId");

                    b.HasOne("Infobase.Models.PASS.IndicatorGroup", "IndicatorGroup")
                        .WithMany("LifeCourses")
                        .HasForeignKey("IndicatorGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.Measure", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Strata", "DefaultStrata")
                        .WithMany()
                        .HasForeignKey("DefaultStrataId");

                    b.HasOne("Infobase.Models.PASS.Indicator", "Indicator")
                        .WithMany("Measures")
                        .HasForeignKey("IndicatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.Point", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Strata", "Strata")
                        .WithMany("Points")
                        .HasForeignKey("StrataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infobase.Models.PASS.Strata", b =>
                {
                    b.HasOne("Infobase.Models.PASS.Measure", "Measure")
                        .WithMany("Stratas")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
