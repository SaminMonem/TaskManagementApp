using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManagement1;
using System.Windows.Forms;
using System;
using TaskManagementApp;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        public class TestTasks
        {
            [TestMethod]
            public void TestMethod1()
            {
            }
            public void TestGetAllTasks()
            {
                // Arrange
                var tasksForm = new Tasks();

                // Act
                var result = tasksForm.GetAllTasks();

                // Assert
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(DataGridViewRowCollection));

            }
        }
        
        public class TestProjects
        {
            public void TestGetAllProjects()
            {
                // Arrange
                var projectsForm = new Project();

                // Act
                var result = projectsForm.GetAllProjects();

                // Assert
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(DataGridViewRowCollection));

            }
        }

        public class TestEvents
        {
            public void TestGetAllEvents()
            {
                // Arrange
                var eventsForm = new Events();

                // Act
                var result = eventsForm.GetAllEvents();

                // Assert
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(DataGridViewRowCollection));

            }
        }

        /**
        public class TestAI
        {
            [TestMethod]
            public void TestLoadTasksFormCsv()
            {
            
                var aiForm = new AI();
                var result = aiForm.LoadTasksFormCsv();

                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(DataGridViewRowCollection));

            }

        }
        **/

        public class TestAI
        {
            [TestMethod]
            public void TestLoadTasksFormCsv()
            {
                // Arrange
                var aiForm = new AI();

                // Act
                aiForm.LoadTasksFormCsv();

                // Assert
                Assert.IsNotNull(aiForm.Project_Management_Data);
                Assert.IsTrue(aiForm.Project_Management_Data.Count > 0);
            }
        }

        [TestClass]
        public class CalendarTests
        {
            [TestMethod]
            public void TestDisplayDays()
            {
                // Arrange
                var calendarForm = new Calendar();

                // Act
                calendarForm.displayDays();

            }
        }

        [TestClass]
        public class DashboardTests
        {
            private object expectedValue;

            [TestMethod]
            public void TestCountTasks()
            {
                // Arrange
                var dashboardForm = new Dashboard();

                // Act
                dashboardForm.CountTasks();

                // Assert
                //Assert.AreEqual(expectedValue, dashboardForm.NumTasks.Text);
                //Assert.AreEqual(expectedValue, dashboardForm.NumProjects.Text);
                //Assert.AreEqual(expectedValue, dashboardForm.NumEvents.Text);
            }

        }
    }
}
