﻿using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using StandardRepository.Models.Entities;

using Translation.Common.Models.Requests.Label;
using Translation.Common.Models.Requests.Label.LabelTranslation;
using Translation.Common.Models.Shared;
using Translation.Data.Entities.Domain;
using Translation.Data.Entities.Main;
using Translation.Data.Entities.Parameter;
using static Translation.Tests.TestHelpers.FakeConstantTestHelper;

namespace Translation.Tests.TestHelpers
{
    public class FakeEntityTestHelper
    {
        public static Integration GetIntegration()
        {
            var integration = new Integration();
            integration.OrganizationId = LongOne;
            integration.OrganizationUid = UidOne;
            integration.OrganizationName = StringOne;

            integration.Id = LongOne;
            integration.Uid = UidOne;
            integration.Name = StringOne;

            integration.CreatedAt = DateTimeOne;
            integration.IsActive = BooleanTrue;

            return integration;
        }

        public static Integration GetIntegrationNotExist()
        {
            var integration = GetIntegration();
            integration.Id = Zero;

            return integration;
        }

        public static Integration GetOrganizationOneIntegrationOne()
        {
            var integration = new Integration();
            integration.OrganizationId = OrganizationOneId;
            integration.OrganizationUid = OrganizationOneUid;
            integration.OrganizationName = OrganizationOneName;

            integration.Id = OrganizationOneIntegrationOneId;
            integration.Uid = OrganizationOneIntegrationOneUid;
            integration.Name = OrganizationOneIntegrationOneName;

            integration.CreatedAt = DateTimeOne;
            integration.IsActive = BooleanTrue;

            return integration;
        }

        public static Integration GetOrganizationOneIntegrationOneNotActive()
        {
            var integration = GetOrganizationOneIntegrationOne();
            integration.IsActive = BooleanFalse;

            return integration;
        }

        public static Integration GetOrganizationOneIntegrationOneNotExist()
        {
            var integration = GetOrganizationOneIntegrationOne();
            integration.Id = Zero;

            return integration;
        }

        public static Integration GetOrganizationTwoIntegrationOne()
        {
            var integration = new Integration();
            integration.OrganizationId = OrganizationTwoId;
            integration.OrganizationUid = OrganizationTwoUid;
            integration.OrganizationName = OrganizationTwoName;

            integration.Id = OrganizationTwoIntegrationOneId;
            integration.Uid = OrganizationTwoIntegrationOneUid;
            integration.Name = OrganizationTwoIntegrationOneName;

            integration.CreatedAt = DateTimeOne;
            integration.IsActive = BooleanTrue;

            return integration;
        }

        public static IntegrationClient GetOrganizationOneIntegrationOneIntegrationClientOneNotExist()
        {
            var integrationClient = GetOrganizationOneIntegrationOneIntegrationClientOne();
            integrationClient.Id = Zero;

            return integrationClient;
        }

        public static IntegrationClient GetOrganizationOneIntegrationOneIntegrationClientOne()
        {
            var integrationClient = new IntegrationClient();
            integrationClient.OrganizationId = OrganizationOneId;
            integrationClient.OrganizationUid = OrganizationOneUid;
            integrationClient.OrganizationName = OrganizationOneName;

            integrationClient.IntegrationId = OrganizationOneIntegrationOneId;
            integrationClient.IntegrationUid = OrganizationOneIntegrationOneUid;
            integrationClient.IntegrationName = OrganizationOneIntegrationOneName;

            integrationClient.Id = OrganizationOneIntegrationOneIntegrationClientOneId;
            integrationClient.Uid = OrganizationOneIntegrationOneIntegrationClientOneUid;
            integrationClient.Name = OrganizationOneIntegrationOneIntegrationClientOneName;

            integrationClient.ClientId = UidOne;
            integrationClient.ClientSecret = UidTwo;
            integrationClient.CreatedAt = DateTimeOne;
            integrationClient.IsActive = BooleanTrue;

            return integrationClient;
        }

        public static IntegrationClient GetIntegrationClient()
        {
            var integrationClient = new IntegrationClient();
            integrationClient.OrganizationId = LongOne;
            integrationClient.OrganizationUid = UidOne;
            integrationClient.OrganizationName = StringOne;

            integrationClient.IntegrationId = LongOne;
            integrationClient.IntegrationUid = UidOne;
            integrationClient.IntegrationName = StringOne;

            integrationClient.ClientId = UidOne;
            integrationClient.Id = LongOne;
            integrationClient.Uid = UidOne;

            integrationClient.Name = StringOne;
            integrationClient.CreatedAt = DateTimeOne;
            integrationClient.IsActive = BooleanTrue;

            return integrationClient;
        }

        public static IntegrationClient GetOrganizationTwoIntegrationOneIntegrationClientOne()
        {
            var integrationClient = new IntegrationClient();
            integrationClient.OrganizationId = OrganizationTwoId;
            integrationClient.OrganizationUid = OrganizationTwoUid;
            integrationClient.OrganizationName = OrganizationTwoName;

            integrationClient.IntegrationId = OrganizationTwoIntegrationOneId;
            integrationClient.IntegrationUid = OrganizationTwoIntegrationOneUid;
            integrationClient.IntegrationName = OrganizationTwoIntegrationOneName;

            integrationClient.Id = OrganizationTwoIntegrationOneIntegrationClientOneId;
            integrationClient.Uid = OrganizationTwoIntegrationOneIntegrationClientOneUid;
            integrationClient.Name = OrganizationTwoIntegrationOneIntegrationClientOneName;

            integrationClient.ClientId = UidOne;
            integrationClient.ClientSecret = UidTwo;
            integrationClient.CreatedAt = DateTimeOne;
            integrationClient.IsActive = BooleanTrue;

            return integrationClient;
        }

        public static EntityRevision<Integration> GetIntegrationRevisionTwo()
        {
            var revision = new EntityRevision<Integration>();

            revision.Id = LongOne;
            revision.Entity = GetIntegration();
            revision.Revision = Two;
            revision.RevisionedAt = DateTimeOne;
            revision.RevisionedBy = LongOne;

            return revision;
        }

        public static List<EntityRevision<LabelTranslation>> GetOrganizationOneProjectOneLabelOneLabelTranslationOneRevisionsRevisionOneInIt()
        {
            var list = new List<EntityRevision<LabelTranslation>>();
            var revision = new EntityRevision<LabelTranslation>();
            revision.Id = LongOne;
            revision.Revision = One;
            revision.RevisionedAt = DateTimeOne;
            revision.Entity = GetOrganizationOneProjectOneLabelOneLabelTranslationOne();

            list.Add(revision);

            return list;
        }

        public static List<EntityRevision<LabelTranslation>> GetOrganizationOneProjectOneLabelOneLabelTranslationOneRevisionsRevisionTwoInIt()
        {
            var list = new List<EntityRevision<LabelTranslation>>();
            var revision = new EntityRevision<LabelTranslation>();
            revision.Id = LongOne;
            revision.Revision = Two;
            revision.RevisionedAt = DateTimeOne;
            revision.Entity = GetOrganizationOneProjectOneLabelOneLabelTranslationOne();

            list.Add(revision);

            return list;
        }

        public static List<EntityRevision<Integration>> GetOrganizationOneIntegrationOneRevisions()
        {
            var list = new List<EntityRevision<Integration>>();
            var revision = new EntityRevision<Integration>();
            revision.Id = LongOne;
            revision.Revision = One;
            revision.RevisionedAt = DateTimeOne;
            revision.Entity = GetOrganizationOneIntegrationOne();

            list.Add(revision);

            return list;
        }

        public static Token GetToken()
        {
            var token = new Token();
            token.OrganizationId = LongOne;
            token.OrganizationUid = UidOne;
            token.OrganizationName = StringOne;

            token.IntegrationId = LongOne;
            token.IntegrationUid = UidOne;
            token.IntegrationName = StringOne;

            token.Id = LongOne;
            token.Uid = UidOne;
            token.Name = StringOne;

            token.CreatedAt = DateTimeOne;
            token.IsActive = BooleanTrue;

            return token;
        }

        public static Token GetOrganizationOneIntegrationOneIntegrationClientOneTokenOneNotExist()
        {
            var token = GetOrganizationOneIntegrationOneIntegrationClientOneTokenOne();
            token.Id = Zero;
            return token;
        }

        public static Token GetOrganizationOneIntegrationOneIntegrationClientOneTokenOne()
        {

            var token = new Token();
            token.OrganizationId = OrganizationOneId;
            token.OrganizationUid = OrganizationOneUid;
            token.OrganizationName = OrganizationOneName;

            token.IntegrationId = OrganizationOneIntegrationOneId;
            token.IntegrationUid = OrganizationOneIntegrationOneUid;
            token.IntegrationName = OrganizationOneIntegrationOneName;

            token.Id = OrganizationOneIntegrationOneIntegrationClientOneId;
            token.Uid = OrganizationOneIntegrationOneIntegrationClientOneUid;
            token.Name = OrganizationOneIntegrationOneIntegrationClientOneName;


            token.CreatedAt = DateTimeOne;
            token.IsActive = BooleanTrue;

            return token;
        }

        public static Token GetOrganizationTwoIntegrationOneIntegrationClientOneTokenOne()
        {
            var token = new Token();
            token.OrganizationId = OrganizationTwoId;
            token.OrganizationUid = OrganizationOneUid;
            token.OrganizationName = OrganizationOneName;

            token.IntegrationId = OrganizationOneIntegrationOneId;
            token.IntegrationUid = OrganizationOneIntegrationOneUid;
            token.IntegrationName = OrganizationOneIntegrationOneName;

            token.Id = OrganizationOneIntegrationOneIntegrationClientOneId;
            token.Uid = OrganizationOneIntegrationOneIntegrationClientOneUid;
            token.Name = OrganizationOneIntegrationOneIntegrationClientOneName;


            token.CreatedAt = DateTimeOne;
            token.IsActive = BooleanTrue;

            return token;
        }

        public static TokenRequestLog GetTokenRequestLog()
        {
            var tokenRequestLog = new TokenRequestLog();
            tokenRequestLog.OrganizationId = LongOne;
            tokenRequestLog.OrganizationUid = UidOne;
            tokenRequestLog.OrganizationName = StringOne;

            tokenRequestLog.IntegrationId = LongOne;
            tokenRequestLog.IntegrationUid = UidOne;
            tokenRequestLog.IntegrationName = StringOne;

            tokenRequestLog.IntegrationClientId = LongOne;
            tokenRequestLog.IntegrationClientUid = UidOne;
            tokenRequestLog.IntegrationClientName = StringOne;

            tokenRequestLog.Id = LongOne;
            tokenRequestLog.Uid = UidOne;
            tokenRequestLog.Name = StringOne;
            tokenRequestLog.CreatedAt = DateTimeOne;

            tokenRequestLog.City = StringOne;
            tokenRequestLog.Country = StringOne;
            tokenRequestLog.Ip = IpOne;

            return tokenRequestLog;
        }

        public static Project GetProject()
        {
            var project = new Project();
            project.OrganizationId = LongOne;
            project.OrganizationUid = UidOne;
            project.OrganizationName = StringOne;

            project.LabelCount = One;
            project.LabelTranslationCount = Two;

            project.IsActive = BooleanTrue;

            return project;
        }

        public static Project GetOrganizationTwoProjectOne()
        {
            var project = new Project();
            project.Id = OrganizationTwoProjectOneId;
            project.Uid = OrganizationTwoProjectOneUid;
            project.Name = OrganizationTwoProjectOneName;

            project.OrganizationId = OrganizationTwoId;
            project.OrganizationUid = OrganizationTwoUid;
            project.OrganizationName = OrganizationTwoName;

            project.IsActive = BooleanTrue;
            project.Url = HttpUrl;
            project.CreatedAt = DateTimeOne;

            return project;
        }

        public static Project GetOrganizationOneProjectOne()
        {
            var project = new Project();
            project.Id = OrganizationOneProjectOneId;
            project.Uid = OrganizationOneProjectOneUid;
            project.Name = OrganizationOneProjectOneName;

            project.OrganizationId = OrganizationOneId;
            project.OrganizationUid = OrganizationOneUid;
            project.OrganizationName = OrganizationOneName;

            project.IsActive = BooleanTrue;
            project.Url = HttpUrl;
            project.CreatedAt = DateTimeOne;

            project.Slug = OrganizationOneProjectOneSlug;

            return project;
        }

        public static Project GetOrganizationOneSuperProjectOne()
        {
            var project = GetOrganizationOneProjectOne();
            project.IsSuperProject = BooleanTrue;

            return project;
        }

        public static Project GetOrganizationOneProjectOneNotExist()
        {
            var project = GetOrganizationOneProjectOne();
            project.Id = Zero;

            return project;
        }

        public static Project GetOrganizationOneProjectOneNotActive()
        {
            var project = GetOrganizationOneProjectOne();
            project.IsActive = BooleanFalse;

            return project;
        }

        public static Organization GetOrganization()
        {
            var organization = new Organization();
            organization.Id = LongOne;
            organization.Uid = UidOne;
            organization.Name = StringOne;

            organization.CreatedAt = DateTimeOne;
            organization.Description = StringOne;
            organization.IsActive = BooleanTrue;

            organization.ObfuscationKey = StringSixtyFourOne;

            organization.IsActive = BooleanTrue;

            return organization;
        }

        public static Organization GetOrganizationOne()
        {
            var organization = new Organization();
            organization.Id = OrganizationOneId;
            organization.Uid = OrganizationOneUid;
            organization.Name = OrganizationOneName;
            organization.CreatedAt = DateTimeOne;
            organization.Description = StringOne;
            organization.IsActive = BooleanTrue;
            organization.ObfuscationKey = StringSixtyFourOne;

            organization.IsActive = BooleanTrue;

            return organization;
        }

        public static Organization GetOrganizationOneNotExist()
        {
            var organization = GetOrganizationOne();
            organization.Id = Zero;

            return organization;
        }

        public static Organization GetOrganizationOneNotActive()
        {
            var organization = GetOrganizationOne();
            organization.IsActive = BooleanTrue;

            return organization;
        }

        public static Organization GetOrganizationTwo()
        {
            var organization = new Organization();
            organization.Id = OrganizationTwoId;
            organization.Uid = OrganizationTwoUid;
            organization.Name = OrganizationTwoName;
            organization.CreatedAt = DateTimeOne;
            organization.Description = StringOne;
            organization.IsActive = BooleanTrue;
            organization.ObfuscationKey = StringSixtyFourOne;

            organization.IsActive = BooleanTrue;

            return organization;
        }

        public static CurrentOrganization GetCurrentOrganizationTwo()
        {
            var organization = new CurrentOrganization();
            organization.Id = OrganizationTwoId;
            organization.Uid = OrganizationTwoUid;
            organization.Name = OrganizationTwoName;

            return organization;
        }

        public static CurrentOrganization GetCurrentOrganizationOne()
        {
            var organization = new CurrentOrganization();
            organization.Id = OrganizationOneId;
            organization.Uid = OrganizationOneUid;
            organization.Name = OrganizationOneName;

            return organization;
        }

        public static UserLoginLog GetUserLoginLog()
        {
            var userLoginLog = new UserLoginLog();
            userLoginLog.OrganizationId = LongOne;
            userLoginLog.OrganizationUid = UidOne;
            userLoginLog.OrganizationName = StringOne;

            userLoginLog.Id = LongOne;
            userLoginLog.Uid = UidOne;
            userLoginLog.Name = StringOne;
            userLoginLog.CreatedAt = DateTimeOne;

            userLoginLog.City = StringOne;
            userLoginLog.Country = StringOne;
            userLoginLog.Ip = IpOne;

            return userLoginLog;
        }

        public static User GetUser()
        {
            var user = new User();
            user.OrganizationId = LongOne;
            user.OrganizationUid = UidOne;
            user.OrganizationName = StringOne;

            user.Id = LongOne;
            user.Uid = UidOne;
            user.Name = StringOne;

            user.Email = EmailOne;
            user.IsActive = BooleanTrue;

            return user;
        }

        public static User GetSuperAdmin()
        {
            var user = GetUser();
            user.IsSuperAdmin = BooleanTrue;

            return user;
        }

        public static User GetOrganizationOneUserOne()
        {
            var user = new User();
            user.OrganizationId = OrganizationOneId;
            user.OrganizationUid = OrganizationOneUid;
            user.OrganizationName = OrganizationOneName;

            user.Id = OrganizationOneUserOneId;
            user.Uid = OrganizationOneUserOneUid;
            user.Name = OrganizationOneUserOneName;

            user.Email = OrganizationOneUserOneEmail;
            user.IsActive = BooleanTrue;

            user.ObfuscationSalt = StringSixtyFourOne;
            user.PasswordHash = StringSixtyFourTwo;

            return user;
        }

        public static User GetOrganizationOneUserOneNotExist()
        {
            var user = GetOrganizationOneUserOne();
            user.Id = Zero;

            return user;
        }

        public static User GetOrganizationOneUserOneNotActive()
        {
            var user = GetOrganizationOneUserOne();
            user.IsActive = BooleanFalse;

            return user;
        }

        public static User GetOrganizationOneUserOneNotValid()
        {
            var user = new User();

            return user;
        }

        public static User GetOrganizationOneSuperAdminUserOneInvitedAtOneDayBefore()
        {
            var user = GetOrganizationOneSuperAdminUserOne();
            user.InvitedAt = DateTimeOneDayBefore;

            return user;
        }

        public static User GetOrganizationOneSuperAdminUserOneInvitedAtOneWeekBefore()
        {
            var user = GetOrganizationOneSuperAdminUserOne();
            user.InvitedAt = DateTimeOneWeekBefore;

            return user;
        }

        public static User GetOrganizationOneAdminUserOne()
        {
            var user = GetOrganizationOneUserOne();
            user.IsAdmin = BooleanTrue;

            return user;
        }

        public static User GetOrganizationOneSuperAdminUserOne()
        {
            var user = GetOrganizationOneUserOne();
            user.IsSuperAdmin = BooleanTrue;

            return user;
        }

        public static User GetOrganizationTwoUserOne()
        {
            var user = new User();
            user.OrganizationId = OrganizationTwoId;
            user.OrganizationUid = OrganizationTwoUid;
            user.OrganizationName = OrganizationTwoName;

            user.Id = OrganizationTwoUserOneId;
            user.Uid = OrganizationTwoUserOneUid;
            user.Name = OrganizationTwoUserOneName;

            user.Email = OrganizationTwoUserOneEmail;
            user.IsActive = BooleanTrue;

            return user;
        }

        public static CurrentUser GetOrganizationOneCurrentUserOne()
        {
            var currentOrganization = GetCurrentOrganizationOne();
            var user = new CurrentUser();
            user.Organization = currentOrganization;
            user.Id = OrganizationOneUserOneId;
            user.Uid = OrganizationOneUserOneUid;
            user.Name = OrganizationOneUserOneName;
            user.Email = OrganizationOneUserOneEmail;
            user.IsActive = BooleanTrue;

            return user;
        }

        public static CurrentUser GetOrganizationTwoCurrentUserOne()
        {
            var user = new CurrentUser();
            user.Id = OrganizationTwoUserOneId;
            user.Uid = OrganizationTwoUserOneUid;
            user.Name = OrganizationTwoUserOneName;
            user.Email = OrganizationTwoUserOneEmail;
            user.IsActive = BooleanTrue;

            return user;
        }

        public static Label GetLabel()
        {
            var label = new Label();
            label.OrganizationId = LongOne;
            label.OrganizationUid = UidOne;
            label.OrganizationName = StringOne;

            label.ProjectId = LongOne;
            label.ProjectUid = UidOne;
            label.ProjectName = StringOne;

            label.Id = LongOne;
            label.Uid = UidOne;
            label.Name = StringOne;
            label.Key = StringOne;

            label.IsActive = BooleanTrue;

            return label;
        }

        public static Label GetLabelNotExist()
        {
            var label = GetLabel();
            label.Id = Zero;

            return label;
        }

        public static Label GetLabelNotActive()
        {
            var label = GetLabel();
            label.IsActive = BooleanFalse;

            return label;
        }

        public static Label GetLabelNotValid()
        {
            var label = new Label();

            return label;
        }

        public static Label GetOrganizationOneProjectOneLabelOne()
        {
            var label = new Label();
            label.OrganizationId = OrganizationOneId;
            label.OrganizationUid = OrganizationOneUid;
            label.OrganizationName = OrganizationOneName;

            label.ProjectId = OrganizationOneProjectOneId;
            label.ProjectUid = OrganizationOneProjectOneUid;
            label.ProjectName = OrganizationOneProjectOneName;

            label.Id = OrganizationOneProjectOneLabelOneId;
            label.Uid = OrganizationOneProjectOneLabelOneUid;
            label.Name = OrganizationOneProjectOneLabelOneName;
            label.Key = OrganizationOneProjectOneLabelOneKey;

            label.IsActive = BooleanTrue;

            return label;
        }

        public static Label GetOrganizationTwoProjectOneLabelOne()
        {
            var label = new Label();
            label.OrganizationId = OrganizationTwoId;
            label.OrganizationUid = OrganizationTwoUid;
            label.OrganizationName = OrganizationTwoName;

            label.ProjectId = OrganizationTwoProjectOneId;
            label.ProjectUid = OrganizationTwoProjectOneUid;
            label.ProjectName = OrganizationTwoProjectOneName;

            label.Id = OrganizationTwoProjectOneLabelOneId;
            label.Uid = OrganizationTwoProjectOneLabelOneUid;
            label.Name = OrganizationTwoProjectOneLabelOneName;
            label.Key = OrganizationTwoProjectOneLabelOneKey;

            label.IsActive = BooleanTrue;

            return label;
        }

        public static Label GetOrganizationOneProjectOneLabelOneNotExist()
        {
            var label = GetOrganizationOneProjectOneLabelOne();
            label.Id = Zero;

            return label;
        }

        public static Label GetOrganizationOneProjectOneLabelOneNotActive()
        {
            var label = GetOrganizationOneProjectOneLabelOne();
            label.IsActive = BooleanFalse;

            return label;
        }

        public static Label GetOrganizationOneProjectOneLabelOneNotValid()
        {
            var label = new Label();

            return label;
        }

        public static LabelTranslation GetLabelTranslation()
        {
            var labelTranslation = new LabelTranslation();
            labelTranslation.OrganizationId = LongOne;
            labelTranslation.OrganizationUid = UidOne;
            labelTranslation.OrganizationName = StringOne;

            labelTranslation.ProjectId = LongOne;
            labelTranslation.ProjectUid = UidOne;
            labelTranslation.ProjectName = StringOne;

            labelTranslation.LabelId = LongOne;
            labelTranslation.LabelUid = UidOne;
            labelTranslation.LabelName = StringOne;

            labelTranslation.Id = LongOne;
            labelTranslation.Uid = UidOne;
            labelTranslation.Name = StringOne;

            labelTranslation.IsActive = BooleanTrue;

            return labelTranslation;
        }

        public static LabelTranslation GetLabelTranslationNotExist()
        {
            var labelTranslation = GetLabelTranslation();
            labelTranslation.Id = Zero;

            return labelTranslation;
        }

        public static LabelTranslation GetLabelTranslationNotActive()
        {
            var labelTranslation = GetLabelTranslation();
            labelTranslation.IsActive = BooleanFalse;

            return labelTranslation;
        }

        public static LabelTranslation GetLabelTranslationNotValid()
        {
            var labelTranslation = new LabelTranslation();

            return labelTranslation;
        }

        public static LabelTranslation GetOrganizationOneProjectOneLabelOneLabelTranslationOne()
        {
            var labelTranslation = new LabelTranslation();
            labelTranslation.OrganizationId = OrganizationOneId;
            labelTranslation.OrganizationUid = OrganizationOneUid;
            labelTranslation.OrganizationName = OrganizationOneName;

            labelTranslation.ProjectId = OrganizationOneProjectOneId;
            labelTranslation.ProjectUid = OrganizationOneProjectOneUid;
            labelTranslation.ProjectName = OrganizationOneProjectOneName;

            labelTranslation.LabelId = OrganizationOneProjectOneLabelOneId;
            labelTranslation.LabelUid = OrganizationOneProjectOneLabelOneUid;
            labelTranslation.LabelName = OrganizationOneProjectOneLabelOneName;

            labelTranslation.Id = OrganizationOneProjectOneLabelOneId;
            labelTranslation.Uid = OrganizationOneProjectOneLabelOneUid;
            labelTranslation.Name = OrganizationOneProjectOneLabelOneName;

            labelTranslation.IsActive = BooleanTrue;

            return labelTranslation;
        }

        public static LabelTranslation GetOrganizationTwoProjectOneLabelOneLabelTranslationOne()
        {
            var labelTranslation = new LabelTranslation();
            labelTranslation.OrganizationId = OrganizationTwoId;
            labelTranslation.OrganizationUid = OrganizationTwoUid;
            labelTranslation.OrganizationName = OrganizationTwoName;

            labelTranslation.ProjectId = OrganizationTwoProjectOneId;
            labelTranslation.ProjectUid = OrganizationTwoProjectOneUid;
            labelTranslation.ProjectName = OrganizationTwoProjectOneName;

            labelTranslation.LabelId = OrganizationTwoProjectOneLabelOneId;
            labelTranslation.LabelUid = OrganizationTwoProjectOneLabelOneUid;
            labelTranslation.LabelName = OrganizationTwoProjectOneLabelOneName;

            labelTranslation.Id = OrganizationTwoProjectOneLabelOneId;
            labelTranslation.Uid = OrganizationTwoProjectOneLabelOneUid;
            labelTranslation.Name = OrganizationTwoProjectOneLabelOneName;

            labelTranslation.IsActive = BooleanTrue;

            return labelTranslation;
        }

        public static LabelTranslation GetOrganizationOneProjectOneLabelOneLabelTranslationOneNotExist()
        {
            var labelTranslation = GetOrganizationOneProjectOneLabelOneLabelTranslationOne();
            labelTranslation.Id = Zero;

            return labelTranslation;
        }

        public static LabelTranslation GetOrganizationOneProjectOneLabelOneLabelTranslationOneNotActive()
        {
            var labelTranslation = GetOrganizationOneProjectOneLabelOneLabelTranslationOne();
            labelTranslation.IsActive = BooleanFalse;

            return labelTranslation;
        }

        public static LabelTranslation GetOrganizationOneProjectOneLabelOneLabelTranslationOneNotValid()
        {
            var labelTranslation = new LabelTranslation();

            return labelTranslation;
        }

        public static Language GetLanguageOneNotExist()
        {
            var language = GetLanguageOne();
            language.Id = Zero;

            return language;
        }

        public static Language GetLanguageOne()
        {
            var language = new Language();
            language.Name = "Language One";
            language.Id = LongOne;
            language.Uid = UidOne;

            language.OriginalName = "Language One Original Name";
            language.IsoCode2Char = IsoCode2One;
            language.IsoCode3Char = IsoCode3One;

            return language;
        }

        public static EntityRevision<Language> GetLanguageRevisionOne()
        {
            var revision = new EntityRevision<Language>();

            revision.Id = LongOne;
            revision.Entity = GetLanguageOne();
            revision.Revision = One;
            revision.RevisionedAt = DateTimeOne;
            revision.RevisionedBy = LongOne;

            return revision;
        }

        public static EntityRevision<Language> GetLanguageRevisionTwo()
        {
            var revision = GetLanguageRevisionOne();
            revision.Revision = Two;

            return revision;
        }

        public static List<EntityRevision<Organization>> GetOrganizationOneRevisions()
        {
            var list = new List<EntityRevision<Organization>>();
            var revision = new EntityRevision<Organization>();
            revision.Id = LongOne;
            revision.Revision = One;
            revision.RevisionedAt = DateTimeOne;
            revision.Entity = GetOrganizationOne();

            list.Add(revision);

            return list;
        }

        public static List<EntityRevision<Project>> GetOrganizationOneProjectOneRevisions()
        {
            var list = new List<EntityRevision<Project>>();
            var revision = new EntityRevision<Project>();
            revision.Id = LongOne;
            revision.Revision = One;
            revision.RevisionedAt = DateTimeOne;
            revision.Entity = GetOrganizationOneProjectOne();

            list.Add(revision);

            return list;
        }

        public static List<EntityRevision<Label>> GetOrganizationOneProjectOneLabelOneRevisionsRevisionOneInIt()
        {
            var list = new List<EntityRevision<Label>>();
            var revision = new EntityRevision<Label>();
            revision.Id = LongOne;
            revision.Revision = One;
            revision.RevisionedAt = DateTimeOne;
            revision.Entity = GetOrganizationOneProjectOneLabelOne();

            list.Add(revision);

            return list;
        }

        public static List<EntityRevision<Label>> GetOrganizationOneProjectOneLabelOneRevisionsRevisionTwoInIt()
        {
            var list = new List<EntityRevision<Label>>();
            var revision = new EntityRevision<Label>();
            revision.Id = LongOne;
            revision.Revision = Two;
            revision.RevisionedAt = DateTimeOne;
            revision.Entity = GetOrganizationOneProjectOneLabelOne();

            list.Add(revision);

            return list;
        }

        public static PagingInfo GetPagingInfoForSelectAfter()
        {
            var pagingInfo = new PagingInfo();
            pagingInfo.Skip = Zero;
            pagingInfo.Take = Three;
            pagingInfo.IsAscending = BooleanTrue;
            pagingInfo.LastUid = UidOne;
            pagingInfo.TotalItemCount = Ten;

            return pagingInfo;
        }

        public static PagingInfo GetPagingInfoForSelectMany()
        {
            var pagingInfo = new PagingInfo();
            pagingInfo.Skip = One;
            pagingInfo.Take = Three;
            pagingInfo.IsAscending = BooleanTrue;
            pagingInfo.TotalItemCount = Ten;
            pagingInfo.LastUid = UidOne;
            pagingInfo.TotalItemCount = Ten;

            return pagingInfo;

        }

        public static LabelListInfo GetLabelListInfo()
        {
            var labelListInfo = new LabelListInfo();
            labelListInfo.LabelKey = StringOne;
            labelListInfo.LanguageIsoCode2 = IsoCode2One;
            labelListInfo.Translation = StringOne;

            return labelListInfo;
        }

        public static TranslationListInfo GetTranslationListInfo()
        {
            var translationListInfo = new TranslationListInfo();
            translationListInfo.LanguageIsoCode2 = IsoCode2One;
            translationListInfo.Translation = StringOne;

            return translationListInfo;
        }

        public static ClientLogInfo GetClientLogInfo()
        {
            var clientLogInfo = new ClientLogInfo();
            clientLogInfo.Country = StringOne;
            clientLogInfo.City = StringOne;
            clientLogInfo.Ip = IpOne;

            return clientLogInfo;
        }

        public static Journal GetJournal()
        {
            var journal = new Journal();
            journal.OrganizationId = LongOne;
            journal.OrganizationUid = UidOne;
            journal.OrganizationName = StringOne;

            journal.IntegrationId = LongOne;
            journal.IntegrationUid = UidOne;
            journal.IntegrationName = StringOne;

            journal.UserId = LongOne;
            journal.UserUid = UidOne;
            journal.UserName = StringOne;

            journal.Message = StringOne;

            return journal;
        }

        public static SendEmailLog GetSendEmailLog()
        {
            var sendEmailLog = new SendEmailLog();
            sendEmailLog.OrganizationId = LongOne;
            sendEmailLog.OrganizationUid = UidOne;
            sendEmailLog.OrganizationName = StringOne;

            sendEmailLog.Id = LongOne;
            sendEmailLog.Uid = UidOne;
            sendEmailLog.Name = StringOne;
            sendEmailLog.CreatedAt = DateTimeOne;

            sendEmailLog.EmailFrom = StringOne;
            sendEmailLog.EmailTo = StringOne;
            sendEmailLog.Subject = StringOne;

            return sendEmailLog;
        }

        public static (bool, Organization, User) GetTrueOrganizationUser()
        {
            var uowResult = BooleanTrue;
            var organization = GetOrganization();
            var user = GetUser();

            return (uowResult, organization, user);
        }

        public static (bool, Organization, User) GetFalseOrganizationUser()
        {
            var uowResult = BooleanFalse;
            var organization = GetOrganization();
            var user = GetUser();

            return (uowResult, organization, user);
        }

        public static IFormFile GetUploadLabelCsvTemplateFileThreeValue()
        {
            //Arrange
            var fileMock = new Mock<IFormFile>();
            //Setup mock file using a memory stream
            var content = "label_key,language_char_code_2,translation\n" +
                          "label,tr,Turkish";
            var fileName = "test.csv";
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.Write(content);
            writer.Flush();
            ms.Position = 0;
            fileMock.Setup(x => x.OpenReadStream()).Returns(ms);
            fileMock.Setup(x => x.FileName).Returns(fileName);
            fileMock.Setup(x => x.Length).Returns(ms.Length);

            return fileMock.Object;
        }

        public static IFormFile GetUploadLabelCsvTemplateFileNotThreeValue()
        {
            //Arrange
            var fileMock = new Mock<IFormFile>();
            //Setup mock file using a memory stream
            var content = "label_key,language_char_code_2,translation\n" +
                          "tr,Turkish";
            var fileName = "test.csv";
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.Write(content);
            writer.Flush();
            ms.Position = 0;
            fileMock.Setup(x => x.OpenReadStream()).Returns(ms);
            fileMock.Setup(x => x.FileName).Returns(fileName);
            fileMock.Setup(x => x.Length).Returns(ms.Length);

            return fileMock.Object;
        }

        public static IFormFile GetUploadLabelCsvTemplateFileTwoLength()
        {
            //Arrange
            var fileMock = new Mock<IFormFile>();
            //Setup mock file using a memory stream
            var content = "language_Iso_Code_2,translation\n" +
                          "tr,Turkish";
            var fileName = "test.csv";
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.Write(content);
            writer.Flush();
            ms.Position = 0;
            fileMock.Setup(x => x.OpenReadStream()).Returns(ms);
            fileMock.Setup(x => x.FileName).Returns(fileName);
            fileMock.Setup(x => x.Length).Returns(ms.Length);

            return fileMock.Object;
        }

        public static IFormFile GetUploadLabelCsvTemplateFileNotTwoLength()
        {
            //Arrange
            var fileMock = new Mock<IFormFile>();
            //Setup mock file using a memory stream
            var content = "language_Iso_Code_2,translation\n" +
                          "Label,tr,Turkish";
            var fileName = "test.csv";
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.Write(content);
            writer.Flush();
            ms.Position = 0;
            fileMock.Setup(x => x.OpenReadStream()).Returns(ms);
            fileMock.Setup(x => x.FileName).Returns(fileName);
            fileMock.Setup(x => x.Length).Returns(ms.Length);

            return fileMock.Object;
        }

        public static IFormFile GetLanguageOneCreateIcon()
        {
            //Arrange
            var fileMock = new Mock<IFormFile>();
            //Setup mock file using a memory stream

            var fileName = "test.png";
            var sourceImg = Encoding.UTF8.GetBytes("dummy image");
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.Write(sourceImg);
            writer.Flush();
            ms.Position = 0;
            fileMock.Setup(x => x.OpenReadStream()).Returns(ms);
            fileMock.Setup(x => x.Length).Returns(ms.Length);
            fileMock.Setup(x => x.FileName).Returns(fileName);
            fileMock.Setup(x => x.ContentType).Returns("image/png");

            //var fileMock = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("dummy image")), 0, 0, "Data", "image.png");
            //fileMock.ContentType = "image/png";
            return fileMock.Object;
        }

    }
}