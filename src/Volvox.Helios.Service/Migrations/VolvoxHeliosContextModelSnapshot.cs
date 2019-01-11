﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volvox.Helios.Domain.Module;
using Volvox.Helios.Service;

namespace Volvox.Helios.Service.Migrations
{
    [DbContext(typeof(VolvoxHeliosContext))]
    partial class VolvoxHeliosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Volvox.Helios.Core.Modules.StreamAnnouncer.StreamAnnouncerMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ChannelId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("MessageId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("UserId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("StreamAnnouncerMessages");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ChatTracker.Message", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("AuthorId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("ChannelId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Deleted");

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<DateTimeOffset>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ChannelId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("MessageId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("PollTitle")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("Poll");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.RecurringReminderMessage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ChannelId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("CronExpression")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("Enabled");

                    b.Property<int>("Fault")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("Message")
                        .IsRequired();

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("GuildId");

                    b.ToTable("RecurringReminderMessages");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.StreamerChannelSettings", b =>
                {
                    b.Property<decimal>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("RemoveMessage");

                    b.HasKey("ChannelId");

                    b.HasIndex("GuildId");

                    b.ToTable("StreamerChannelSettings");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.WhiteListedRole", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal?>("StreamerSettingsGuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("Id");

                    b.HasIndex("StreamerSettingsGuildId");

                    b.ToTable("WhiteListedRole");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.ChatTrackerSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.HasKey("GuildId");

                    b.ToTable("ChatTrackerSettings");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.PollSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("GuildId");

                    b.ToTable("PollSettings");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.RemembotSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.HasKey("GuildId");

                    b.ToTable("ReminderSettings");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.StreamerSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.Property<decimal>("RoleId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("StreamerRoleEnabled");

                    b.HasKey("GuildId");

                    b.ToTable("StreamerSettings");
                });

            modelBuilder.Entity("Volvox.Helios.Core.Modules.StreamAnnouncer.StreamAnnouncerMessage", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.StreamerSettings", "StreamerSettings")
                        .WithMany("StreamMessages")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.Poll", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.PollSettings", "PollSettings")
                        .WithMany("Polls")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.RecurringReminderMessage", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.RemembotSettings")
                        .WithMany("RecurringReminders")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.StreamerChannelSettings", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.StreamerSettings", "StreamerSettings")
                        .WithMany("ChannelSettings")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.WhiteListedRole", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.StreamerSettings")
                        .WithMany("WhiteListedRoleIds")
                        .HasForeignKey("StreamerSettingsGuildId");
                });
#pragma warning restore 612, 618
        }
    }
}
