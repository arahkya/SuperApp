using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTaskTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("03b31f58-aafe-7ac9-9c0e-2c50280dd5b8"), "Create a visually appealing landing page for marketing.", "Design Landing Page" },
                    { new Guid("0536a50b-ce48-7563-95ab-8336e5c02382"), "Secure the application with HTTPS.", "Configure SSL Certificates" },
                    { new Guid("0be2285a-01b9-7677-b235-0ea0bb63181d"), "Plan and implement regular data backups.", "Create Backup Strategy" },
                    { new Guid("0ce75541-8f68-7c96-971d-b0c18e251b21"), "Ensure code reliability with unit test coverage.", "Write Unit Tests" },
                    { new Guid("0fdaa886-4ee5-7d53-af70-cdfe5891247f"), "Track changes in user roles and permissions.", "Set Up Role Auditing" },
                    { new Guid("23f98e28-9302-7a62-a21f-4aba8049c1f3"), "Add support for online payments using Stripe.", "Integrate Payment Gateway" },
                    { new Guid("25335252-e71d-7322-994d-dbc32d249c8e"), "Improve page load speed and responsiveness.", "Optimize Frontend Performance" },
                    { new Guid("2ac037d8-ccff-7b2e-b9c4-f1c5c07aeccf"), "Allow users to export data in CSV format.", "Implement Data Export" },
                    { new Guid("2dbc57a4-dcb8-7e38-bcfa-4e538bce29df"), "Perform load testing to ensure scalability.", "Set Up Load Testing" },
                    { new Guid("2f6f5bb9-ff1f-7c0b-b48f-9cf3c6db158d"), "Implement recurring billing for premium users.", "Develop Subscription System" },
                    { new Guid("30712589-3cff-75a3-a667-ece13f7f7591"), "Add basic image editing tools for users.", "Develop Image Editor" },
                    { new Guid("3a539c4a-e5d7-75b8-a4a2-e4aaf08473fb"), "Compress uploaded files to save storage.", "Develop File Compression" },
                    { new Guid("3e0f06d4-bf71-72d2-9946-21ac609d4dd1"), "Implement email alerts for user activities.", "Set Up Email Notifications" },
                    { new Guid("3fe0ab1c-9ac1-788a-aef3-f10270887a71"), "Enable login via Google and Facebook.", "Integrate Social Login" },
                    { new Guid("43b7e292-3584-7823-97e3-27caa21a4a6c"), "Implement real-time notifications for user actions.", "Develop Notification System" },
                    { new Guid("48cfb48f-89f8-702f-bb89-ba8344474646"), "Provide a dark theme option for the UI.", "Implement Dark Mode" },
                    { new Guid("4ad6e63e-4b4f-767d-a968-fea879cf4f59"), "Set up user roles and permissions for the system.", "Implement Role-Based Access" },
                    { new Guid("542efcde-456a-7d7e-8fd0-e33dda521b1d"), "Add extra security for user accounts.", "Implement Two-Factor Authentication" },
                    { new Guid("569bd1f4-c4e0-71c2-a17c-d0e535e0bc3d"), "Allow users to reset their passwords securely.", "Implement Password Reset" },
                    { new Guid("58d64f63-5a5a-7ade-abab-8ef8eed4553f"), "Use lazy loading for images to improve performance.", "Optimize Image Loading" },
                    { new Guid("59ec754f-ae62-73b7-8046-0fee8bddbf03"), "Ensure data integrity with proper validation.", "Implement Data Validation" },
                    { new Guid("605e0ea5-41bc-72e5-820b-e32b45986db2"), "Generate a sitemap for SEO optimization.", "Create Sitemap" },
                    { new Guid("66297792-78b4-7f85-aa9b-9e7995827864"), "Integrate Google Analytics for tracking user behavior.", "Set Up Analytics" },
                    { new Guid("6935ab0d-a9e5-70d9-8c27-0b475fda2568"), "Add real-time chat functionality for users.", "Develop Chat Feature" },
                    { new Guid("6bee3332-75d8-72c2-aafc-70ed06a8c33a"), "Design a smooth onboarding experience for new users.", "Create Onboarding Flow" },
                    { new Guid("6facf3b9-8a1f-7c19-86c1-fc331b3dd9b0"), "Enable push notifications for mobile users.", "Set Up Push Notifications" },
                    { new Guid("770021b9-88ff-7319-8fea-927cccc31077"), "Design user-friendly error pages.", "Create Custom Error Pages" },
                    { new Guid("798d42c3-a760-780a-8173-686631e49843"), "Develop an admin interface for managing users.", "Create Admin Panel" },
                    { new Guid("80130472-2a00-7f46-98ae-4641f7e25fc7"), "Manage and secure API traffic efficiently.", "Set Up API Gateway" },
                    { new Guid("88383c1a-c7b8-7965-8005-50eba4bad29f"), "Allow users to submit feedback easily.", "Develop Feedback Form" },
                    { new Guid("892aa205-a8a7-7d25-a9b8-fc91b3464523"), "Enhance security by adding HTTP headers.", "Configure Security Headers" },
                    { new Guid("8c96900b-484d-7527-846d-74b522dbcf67"), "Enable tagging for better content organization.", "Develop Tagging System" },
                    { new Guid("9d531d27-c06a-766e-8160-b8f178d5243f"), "Configure automated build and deployment pipeline.", "Set Up CI/CD Pipeline" },
                    { new Guid("a0a57651-e11a-7834-a151-b86163fc1946"), "Configure tools to monitor and report errors.", "Set Up Error Monitoring" },
                    { new Guid("a3511444-682a-7631-ab76-692e94ebbc8f"), "Develop secure login and registration functionality.", "Implement Authentication" },
                    { new Guid("aabe2a3a-bd9e-7517-8e57-e99e4c53d130"), "Build a responsive dashboard for user analytics.", "Develop User Dashboard" },
                    { new Guid("b2162483-224d-7404-be52-e0d9d83635c4"), "Support multiple versions of the API.", "Create API Versioning" },
                    { new Guid("b42132ed-c735-770c-ab7a-4b232e813039"), "Create an optimized schema for the new project database.", "Design Database Schema" },
                    { new Guid("b7d15550-d1a2-7f5c-9b18-47949ccf8a09"), "Add search functionality with filters.", "Implement Search Feature" },
                    { new Guid("bb18fbc1-7f10-792e-ac73-0b54c277ea8c"), "Create reports for user and admin dashboards.", "Develop Reporting Module" },
                    { new Guid("be2f849e-cfcc-7ebd-96f0-5c473813af0e"), "Automatically save user progress in forms.", "Implement Auto-Save Feature" },
                    { new Guid("c2e1c864-e71d-7043-bca5-97fcc8ff70a7"), "Set up centralized logging for error tracking.", "Configure Logging" },
                    { new Guid("c3ef5dce-258e-7823-8dbe-722f0a0f1ad7"), "Allow users to upload files securely.", "Implement File Upload" },
                    { new Guid("c9cc94f7-07ae-7270-b735-c232b106a62a"), "Prevent abuse by limiting API requests.", "Create API Rate Limiting" },
                    { new Guid("ce6114fc-3dd4-7733-bab1-f3004eeb4230"), "Improve database query speed and efficiency.", "Optimize Query Performance" },
                    { new Guid("d03ffa08-1e13-703f-b610-945675990fc7"), "Design and implement the mobile application interface.", "Develop Mobile App UI" },
                    { new Guid("d87fc77d-e061-7438-9994-def849e4654b"), "Write comprehensive documentation for all API endpoints.", "Create API Documentation" },
                    { new Guid("f4e1c6b1-212e-7ca5-a132-4473c111d54c"), "Enable localization for multiple languages.", "Add Multi-Language Support" },
                    { new Guid("f61cbacc-0781-7fe4-a8d2-755e3d3f2e2e"), "Add a help and FAQ section for users.", "Create FAQ Section" },
                    { new Guid("fbb8b432-ee91-7d9b-920b-0014b236a164"), "Ensure high availability with replication.", "Set Up Database Replication" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
