﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volvox.Helios.Domain.Module;
using Volvox.Helios.Service;

namespace Volvox.Helios.Service.Migrations
{
    [DbContext(typeof(VolvoxHeliosContext))]
    [Migration("20181116200122_AddGuildIdFieldBannedWord")]
    partial class AddGuildIdFieldBannedWord
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
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

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.Common.ActivePunishment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PunishType");

                    b.Property<DateTimeOffset>("PunishmentExpires");

                    b.Property<int>("PunishmentId");

                    b.Property<decimal?>("RoleId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("mod_ActivePunishments");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.Common.Punishment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<short?>("PunishDuration");

                    b.Property<int>("PunishType");

                    b.Property<decimal?>("RoleId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<short>("WarningThreshold");

                    b.Property<int>("WarningType");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("mod_punishments");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.Common.Warning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.Property<DateTimeOffset>("WarningExpires");

                    b.Property<DateTimeOffset>("WarningRecieved");

                    b.Property<int>("WarningType");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("mod_warnings");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.LinkFilter.LinkFilter", b =>
                {
                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.Property<int>("WarningExpirePeriod");

                    b.HasKey("GuildId");

                    b.ToTable("mod_link_filters");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.LinkFilter.WhitelistedLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("Link")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("mod_whitelisted_links");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.ProfanityFilter.BannedWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasMaxLength(26);

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("mod_banned_words");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.ProfanityFilter.ProfanityFilter", b =>
                {
                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.Property<bool>("UseDefaultList");

                    b.Property<int>("WarningExpirePeriod");

                    b.HasKey("GuildId");

                    b.ToTable("mod_profanity_filters");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.UserWarnings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("UserId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("mod_users");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.WhitelistedChannel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ChannelId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<int>("WhitelistType");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("mod_whitelisted_channels");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.WhitelistedRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("RoleId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<int>("WhitelistType");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("mod_whitelisted_roles");
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

            modelBuilder.Entity("Volvox.Helios.Domain.Module.StreamAnnouncerChannelSettings", b =>
                {
                    b.Property<decimal>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("GuildId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("RemoveMessage");

                    b.HasKey("ChannelId");

                    b.HasIndex("GuildId");

                    b.ToTable("StreamAnnouncerChannelSettings");
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

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.ModerationSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.HasKey("GuildId");

                    b.ToTable("mod_ModerationSettings");
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

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.StreamAnnouncerSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.HasKey("GuildId");

                    b.ToTable("StreamAnnouncerSettings");
                });

            modelBuilder.Entity("Volvox.Helios.Domain.ModuleSettings.StreamerRoleSettings", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<bool>("Enabled");

                    b.Property<decimal>("RoleId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("GuildId");

                    b.ToTable("StreamerRoleSettings");
                });

            modelBuilder.Entity("Volvox.Helios.Core.Modules.StreamAnnouncer.StreamAnnouncerMessage", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.StreamAnnouncerSettings", "StreamAnnouncerSettings")
                        .WithMany("StreamMessages")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.Common.ActivePunishment", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.Module.ModerationModule.UserWarnings", "User")
                        .WithMany("ActivePunishments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.Common.Punishment", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.ModerationSettings", "Moderationsettings")
                        .WithMany("Punishments")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.Common.Warning", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.Module.ModerationModule.UserWarnings", "User")
                        .WithMany("Warnings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.LinkFilter.LinkFilter", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.ModerationSettings", "ModerationSettings")
                        .WithOne("LinkFilter")
                        .HasForeignKey("Volvox.Helios.Domain.Module.ModerationModule.LinkFilter.LinkFilter", "GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.LinkFilter.WhitelistedLink", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.Module.ModerationModule.LinkFilter.LinkFilter", "LinkFilter")
                        .WithMany("WhitelistedLinks")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.ProfanityFilter.BannedWord", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.Module.ModerationModule.ProfanityFilter.ProfanityFilter", "ProfanityFilter")
                        .WithMany("BannedWords")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.ProfanityFilter.ProfanityFilter", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.ModerationSettings", "ModerationSettings")
                        .WithOne("ProfanityFilter")
                        .HasForeignKey("Volvox.Helios.Domain.Module.ModerationModule.ProfanityFilter.ProfanityFilter", "GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.UserWarnings", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.ModerationSettings", "ModerationSettings")
                        .WithMany("UserWarnings")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.WhitelistedChannel", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.ModerationSettings", "Moderationsettings")
                        .WithMany("WhitelistedChannels")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volvox.Helios.Domain.Module.ModerationModule.WhitelistedRole", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.ModerationSettings", "Moderationsettings")
                        .WithMany("WhitelistedRoles")
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

            modelBuilder.Entity("Volvox.Helios.Domain.Module.StreamAnnouncerChannelSettings", b =>
                {
                    b.HasOne("Volvox.Helios.Domain.ModuleSettings.StreamAnnouncerSettings", "StreamAnnouncerSettings")
                        .WithMany("ChannelSettings")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
