using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using QIAB.Models;

namespace QIAB.Migrations
{
    [DbContext(typeof(QIABContext))]
    [Migration("20161013135442_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QIAB.Models.QuestionModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer")
                        .IsRequired();

                    b.Property<string>("Question")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });
        }
    }
}
