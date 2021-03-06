﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Planner.Api.Model.Context;
using System;

namespace Planner.Api.Migrations
{
    [DbContext(typeof(PlannerContext))]
    [Migration("20171213161415_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Planner.Api.Model.TrainingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CaloriesInDiet");

                    b.Property<string>("Description");

                    b.Property<int>("DietId");

                    b.Property<string>("Name");

                    b.Property<int>("TrainerId");

                    b.HasKey("Id");

                    b.ToTable("TrainingPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
