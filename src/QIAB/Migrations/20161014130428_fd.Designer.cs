using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using QIAB.Models;

namespace QIAB.Migrations
{
    [DbContext(typeof(QIABContext))]
    [Migration("20161014130428_fd")]
    partial class fd
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

                    b.Property<DateTime>("DateEntered");

                    b.Property<string>("PotAnswer1");

                    b.Property<string>("PotAnswer2");

                    b.Property<string>("PotAnswer3");

                    b.Property<string>("Question")
                        .IsRequired();

                    b.Property<Guid>("QuestionType");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QIAB.Models.QuestionType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Special");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");
                });
        }
    }
}
