// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using DriveV3Snippets;
using NUnit.Framework;

namespace DriveV3SnippetsTest
{
    // Unit testcase for drive v3 recover team drive snippet
    [TestFixture]
    public class RecoverTeamDriveTest : BaseTest
    {
        [Test]
        public void TestRecoverTeamDrives()
        {
            var id = CreateOrphanedTeamDrive();
            var results = RecoverTeamDrives.DriveRecoverTeamDrives("gduser1@workspacesamples.dev");
            Assert.AreNotEqual(0, results.Count);
            service.Teamdrives.Delete(id).Execute();
        }

        private string CreateOrphanedTeamDrive()
        {
            var teamDriveId = CreateTeamDrive.DriveCreateTeamDrive();
            var listRequest = service.Permissions.List(teamDriveId);
            listRequest.SupportsTeamDrives = true;
            var response = listRequest.Execute();

            foreach (var permission in response.Permissions)
            {
                var deleteRequest = service.Permissions.Delete(teamDriveId, permission.Id);
                deleteRequest.SupportsTeamDrives = true;
                deleteRequest.Execute();
            }
            return teamDriveId;
        }
    }
}