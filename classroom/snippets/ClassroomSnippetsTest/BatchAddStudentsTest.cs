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

using System.Collections.Generic;
using NUnit.Framework;
using ClassroomSnippets;

namespace ClassroomSnippetsTest;

public class BatchAddStudentsTest : BaseTest
{
  [Test]
  public void TestBatchAddStudents()
  {
    var studentEmails = new List<string>()
    {
      "erics@homeroomacademy.com",
      "zach@homeroomacademy.com"
    };
    BatchAddStudents.ClassroomBatchAddStudents(this.TestCourse.Id, studentEmails);
  }
}