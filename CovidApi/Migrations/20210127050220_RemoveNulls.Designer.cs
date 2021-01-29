﻿// <auto-generated />
using System;
using CovidApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CovidApi.Migrations
{
    [DbContext(typeof(CovidApiContext))]
    [Migration("20210127050220_RemoveNulls")]
    partial class RemoveNulls
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CovidApi.Models.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Sex");

                    b.HasKey("DiagnosisId");

                    b.ToTable("Diagnoses");

                    b.HasData(
                        new
                        {
                            DiagnosisId = 1,
                            Age = 20,
                            Sex = "Female"
                        });
                });

            modelBuilder.Entity("CovidApi.Models.Evidence", b =>
                {
                    b.Property<int>("EvidenceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AgeAnswer");

                    b.Property<bool?>("Cough");

                    b.Property<int?>("DiagnosisId");

                    b.Property<string>("Explanation");

                    b.Property<bool?>("Fever");

                    b.Property<string>("Question");

                    b.Property<string>("SexAnswer");

                    b.Property<bool?>("Sob");

                    b.Property<bool?>("YesNo");

                    b.HasKey("EvidenceId");

                    b.HasIndex("DiagnosisId");

                    b.ToTable("Evidences");

                    b.HasData(
                        new
                        {
                            EvidenceId = 1,
                            AgeAnswer = 1,
                            Cough = false,
                            DiagnosisId = 1,
                            Explanation = "false",
                            Fever = false,
                            Question = "What is your sex?",
                            SexAnswer = "false",
                            Sob = false,
                            YesNo = false
                        },
                        new
                        {
                            EvidenceId = 2,
                            AgeAnswer = 1,
                            Cough = false,
                            DiagnosisId = 1,
                            Explanation = "false",
                            Fever = false,
                            Question = "What is your age?",
                            SexAnswer = "false",
                            Sob = false,
                            YesNo = false
                        },
                        new
                        {
                            EvidenceId = 3,
                            AgeAnswer = 1,
                            Cough = false,
                            DiagnosisId = 1,
                            Explanation = "false",
                            Fever = false,
                            Question = "Do you have an underlying conditions that put you at a high risk? List all that apply.",
                            SexAnswer = "false",
                            Sob = false,
                            YesNo = false
                        },
                        new
                        {
                            EvidenceId = 4,
                            AgeAnswer = 1,
                            Cough = false,
                            DiagnosisId = 1,
                            Explanation = "false",
                            Fever = false,
                            Question = "Do you have any of the following symptoms?",
                            SexAnswer = "false",
                            Sob = false,
                            YesNo = false
                        },
                        new
                        {
                            EvidenceId = 5,
                            AgeAnswer = 1,
                            Cough = false,
                            DiagnosisId = 1,
                            Explanation = "false",
                            Fever = false,
                            Question = "Do you have any other symptoms? List all that apply",
                            SexAnswer = "false",
                            Sob = false,
                            YesNo = false
                        },
                        new
                        {
                            EvidenceId = 6,
                            AgeAnswer = 1,
                            Cough = false,
                            DiagnosisId = 1,
                            Explanation = "false",
                            Fever = false,
                            Question = "Have you recently lost the ability to smell or taste?",
                            SexAnswer = "false",
                            Sob = false,
                            YesNo = false
                        },
                        new
                        {
                            EvidenceId = 7,
                            AgeAnswer = 1,
                            Cough = false,
                            DiagnosisId = 1,
                            Explanation = "false",
                            Fever = false,
                            Question = "Please explain your current exposure level.",
                            SexAnswer = "false",
                            Sob = false,
                            YesNo = false
                        },
                        new
                        {
                            EvidenceId = 8,
                            AgeAnswer = 1,
                            Cough = false,
                            DiagnosisId = 1,
                            Explanation = "false",
                            Fever = false,
                            Question = "Have you recently traveled?",
                            SexAnswer = "false",
                            Sob = false,
                            YesNo = false
                        });
                });

            modelBuilder.Entity("CovidApi.Models.Evidence", b =>
                {
                    b.HasOne("CovidApi.Models.Diagnosis", "Diagnosis")
                        .WithMany("Evidences")
                        .HasForeignKey("DiagnosisId");
                });
#pragma warning restore 612, 618
        }
    }
}
