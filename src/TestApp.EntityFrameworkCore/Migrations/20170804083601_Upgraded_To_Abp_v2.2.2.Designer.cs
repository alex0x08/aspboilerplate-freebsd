using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TestApp.EntityFrameworkCore;

namespace TestApp.Migrations
{
    [DbContext(typeof(TestAppDbContext))]
    [Migration("20170804083601_Upgraded_To_Abp_v2.2.2")]
    partial class Upgraded_To_Abp_v222
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Abp.Application.Editions.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<bool>("IsDeleted");
                       // .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("AbpEditions");
                });

            modelBuilder.Entity("Abp.Application.Features.FeatureSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.ToTable("AbpFeatures");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FeatureSetting");
                });

            modelBuilder.Entity("Abp.Auditing.AuditLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("BrowserInfo")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ClientIpAddress")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("ClientName")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("CustomData")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Exception")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int>("ExecutionDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnType("timestamp");

                    b.Property<int?>("ImpersonatorTenantId")
                        .HasColumnType("int");

                    b.Property<long?>("ImpersonatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("MethodName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Parameters")
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ServiceName")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "ExecutionDuration");

                    b.HasIndex("TenantId", "ExecutionTime");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpAuditLogs");
                });

            modelBuilder.Entity("Abp.Authorization.PermissionSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("varchar(2000)");

                    b.Property<bool>("IsGranted");
                       // .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Name");

                    b.ToTable("AbpPermissions");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PermissionSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ClaimType")
                        .HasColumnType("varchar(450)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("varchar(2000)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("TenantId", "ClaimType");

                    b.ToTable("AbpRoleClaims");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("varchar(450)");

                    b.Property<bool>("IsDeleted");
                       // .HasColumnType("boolean");

                    b.Property<DateTime?>("LastLoginTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("bigint");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserLinkId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EmailAddress");

                    b.HasIndex("UserName");

                    b.HasIndex("TenantId", "EmailAddress");

                    b.HasIndex("TenantId", "UserId");

                    b.HasIndex("TenantId", "UserName");

                    b.ToTable("AbpUserAccounts");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ClaimType")
                        .HasColumnType("varchar(450)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("varchar(2000)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "ClaimType");

                    b.ToTable("AbpUserClaims");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "UserId");

                    b.HasIndex("TenantId", "LoginProvider", "ProviderKey");

                    b.ToTable("AbpUserLogins");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserLoginAttempt", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("BrowserInfo")
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ClientIpAddress")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("ClientName")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<byte>("Result")
                        .HasColumnType("int");

                    b.Property<string>("TenancyName")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserNameOrEmailAddress")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("UserId", "TenantId");

                    b.HasIndex("TenancyName", "UserNameOrEmailAddress", "Result");

                    b.ToTable("AbpUserLoginAttempts");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserOrganizationUnit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted");
                       // .HasColumnType("boolean");

                    b.Property<long>("OrganizationUnitId")
                        .HasColumnType("bigint");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "OrganizationUnitId");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpUserOrganizationUnits");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "RoleId");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpUserRoles");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(2000)");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .HasColumnType("varchar(2000)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "UserId");

                    b.ToTable("AbpUserTokens");
                });

            modelBuilder.Entity("Abp.BackgroundJobs.BackgroundJobInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsAbandoned");
                       // .HasColumnType("boolean");

                    b.Property<string>("JobArgs")
                        .IsRequired()
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(1048576);

                    b.Property<string>("JobType")
                        .IsRequired()
                        .HasColumnType("varchar(512)")
                        .HasMaxLength(512);

                    b.Property<DateTime?>("LastTryTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("NextTryTime")
                        .HasColumnType("timestamp");

                    b.Property<byte>("Priority")
                        .HasColumnType("int");

                    b.Property<short>("TryCount")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("IsAbandoned", "NextTryTime");

                    b.ToTable("AbpBackgroundJobs");
                });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("TenantId", "Name");

                    b.ToTable("AbpSettings");
                });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Icon")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted");
                       // .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled");
                       // .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Name");

                    b.ToTable("AbpLanguages");
                });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguageText", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(67108864);

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "Source", "LanguageName", "Key");

                    b.ToTable("AbpLanguageTexts");
                });

            modelBuilder.Entity("Abp.Notifications.NotificationInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Data")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(1048576);

                    b.Property<string>("DataTypeName")
                        .HasColumnType("varchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("EntityId")
                        .HasColumnType("varchar(96)")
                        .HasMaxLength(96);

                    b.Property<string>("EntityTypeAssemblyQualifiedName")
                        .HasColumnType("varchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("EntityTypeName")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("ExcludedUserIds")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(131072);

                    b.Property<string>("NotificationName")
                        .IsRequired()
                        .HasColumnType("varchar(96)")
                        .HasMaxLength(96);

                    b.Property<byte>("Severity")
                        .HasColumnType("int");

                    b.Property<string>("TenantIds")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(131072);

                    b.Property<string>("UserIds")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(131072);

                    b.HasKey("Id");

                    b.ToTable("AbpNotifications");
                });

            modelBuilder.Entity("Abp.Notifications.NotificationSubscriptionInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("EntityId")
                        .HasColumnType("varchar(96)")
                        .HasMaxLength(96);

                    b.Property<string>("EntityTypeAssemblyQualifiedName")
                        .HasColumnType("varchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("EntityTypeName")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NotificationName")
                        .HasColumnType("varchar(96)")
                        .HasMaxLength(96);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("NotificationName", "EntityTypeName", "EntityId", "UserId");

                    b.HasIndex("TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId");

                    b.ToTable("AbpNotificationSubscriptions");
                });

            modelBuilder.Entity("Abp.Notifications.TenantNotificationInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Data")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(1048576);

                    b.Property<string>("DataTypeName")
                        .HasColumnType("varchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("EntityId")
                        .HasColumnType("varchar(96)")
                        .HasMaxLength(96);

                    b.Property<string>("EntityTypeAssemblyQualifiedName")
                        .HasColumnType("varchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("EntityTypeName")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NotificationName")
                        .IsRequired()
                        .HasColumnType("varchar(96)")
                        .HasMaxLength(96);

                    b.Property<byte>("Severity")
                        .HasColumnType("int");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("AbpTenantNotifications");
                });

            modelBuilder.Entity("Abp.Notifications.UserNotificationInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<Guid>("TenantNotificationId")
                        .HasColumnType("uuid");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "State", "CreationTime");

                    b.ToTable("AbpUserNotifications");
                });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(95)")
                        .HasMaxLength(95);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted");
                       // .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("TenantId", "Code");

                    b.ToTable("AbpOrganizationUnits");
                });

            modelBuilder.Entity("TestApp.Authorization.Roles.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(2000)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(5000);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<bool>("IsDefault");
                       // .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted");
                       // .HasColumnType("boolean");

                    b.Property<bool>("IsStatic");
                       // .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("LastModifierUserId");

                    b.HasIndex("TenantId", "NormalizedName");

                    b.ToTable("AbpRoles");
                });

            modelBuilder.Entity("TestApp.Authorization.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AuthenticationSource")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(2000)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("EmailConfirmationCode")
                        .HasColumnType("varchar(328)")
                        .HasMaxLength(328);

                    b.Property<bool>("IsActive");
                       // .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted");
                       // .HasColumnType("boolean");

                    b.Property<bool>("IsEmailConfirmed");
                       // .HasColumnType("boolean");

                    b.Property<bool>("IsLockoutEnabled");
                       // .HasColumnType("boolean");

                    b.Property<bool>("IsPhoneNumberConfirmed");
                       // .HasColumnType("boolean");

                    b.Property<bool>("IsTwoFactorEnabled");
                       // .HasColumnType("boolean");

                    b.Property<DateTime?>("LastLoginTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("LockoutEndDateUtc")
                        .HasColumnType("timestamp");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("NormalizedEmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("PasswordResetCode")
                        .HasColumnType("varchar(328)")
                        .HasMaxLength(328);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("LastModifierUserId");

                    b.HasIndex("TenantId", "NormalizedEmailAddress");

                    b.HasIndex("TenantId", "NormalizedUserName");

                    b.ToTable("AbpUsers");
                });

            modelBuilder.Entity("TestApp.MultiTenancy.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConnectionString")
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<int?>("EditionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive");
                       // .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted");
                       // .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("TenancyName")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("DeleterUserId");

                    b.HasIndex("EditionId");

                    b.HasIndex("LastModifierUserId");

                    b.HasIndex("TenancyName");

                    b.ToTable("AbpTenants");
                });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
                {
                    b.HasBaseType("Abp.Application.Features.FeatureSetting");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.HasIndex("EditionId", "Name");

                    b.ToTable("AbpFeatures");

                    b.HasDiscriminator().HasValue("EditionFeatureSetting");
                });

            modelBuilder.Entity("Abp.MultiTenancy.TenantFeatureSetting", b =>
                {
                    b.HasBaseType("Abp.Application.Features.FeatureSetting");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasIndex("TenantId", "Name");

                    b.ToTable("AbpFeatures");

                    b.HasDiscriminator().HasValue("TenantFeatureSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
                {
                    b.HasBaseType("Abp.Authorization.PermissionSetting");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasIndex("RoleId");

                    b.ToTable("AbpPermissions");

                    b.HasDiscriminator().HasValue("RolePermissionSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
                {
                    b.HasBaseType("Abp.Authorization.PermissionSetting");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasIndex("UserId");

                    b.ToTable("AbpPermissions");

                    b.HasDiscriminator().HasValue("UserPermissionSetting");
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
                {
                    b.HasOne("TestApp.Authorization.Roles.Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
                {
                    b.HasOne("TestApp.Authorization.Users.User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
                {
                    b.HasOne("TestApp.Authorization.Users.User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
                {
                    b.HasOne("TestApp.Authorization.Users.User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
                {
                    b.HasOne("TestApp.Authorization.Users.User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
                {
                    b.HasOne("TestApp.Authorization.Users.User")
                        .WithMany("Settings")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
                {
                    b.HasOne("Abp.Organizations.OrganizationUnit", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("TestApp.Authorization.Roles.Role", b =>
                {
                    b.HasOne("TestApp.Authorization.Users.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("TestApp.Authorization.Users.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("TestApp.Authorization.Users.User", "LastModifierUser")
                        .WithMany()
                        .HasForeignKey("LastModifierUserId");
                });

            modelBuilder.Entity("TestApp.Authorization.Users.User", b =>
                {
                    b.HasOne("TestApp.Authorization.Users.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("TestApp.Authorization.Users.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("TestApp.Authorization.Users.User", "LastModifierUser")
                        .WithMany()
                        .HasForeignKey("LastModifierUserId");
                });

            modelBuilder.Entity("TestApp.MultiTenancy.Tenant", b =>
                {
                    b.HasOne("TestApp.Authorization.Users.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("TestApp.Authorization.Users.User", "DeleterUser")
                        .WithMany()
                        .HasForeignKey("DeleterUserId");

                    b.HasOne("Abp.Application.Editions.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId");

                    b.HasOne("TestApp.Authorization.Users.User", "LastModifierUser")
                        .WithMany()
                        .HasForeignKey("LastModifierUserId");
                });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
                {
                    b.HasOne("Abp.Application.Editions.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
                {
                    b.HasOne("TestApp.Authorization.Roles.Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
                {
                    b.HasOne("TestApp.Authorization.Users.User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}