using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkSchedule.Data.Migrations
{
    public partial class SkillsDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql
                (
                    @"
                    INSERT INTO Skills 
                        (
                            Description
                        )
                    VALUES 
                        (
                            'Communication Skill'
                        ),
                        (
                            'Coding Skill'
                        ),
                        (
                            'Office Application Skill'
                        ),
                        (
                            'Data Entry Skill'
                        ),
                        (
                            'Leadership Skill'
                        ),
                        (
                            'Bookkeeping Skill'
                        ),
                        (
                            'Accounting Skill'
                        ),
                        (
                            'Presentation Skill'
                        ),
                        (
                            'Public Speaking Skill'
                        ),
                        (
                            'Teaching Skill'
                        ),
                        (
                            'Project Management Skill'
                        ),
                        (
                            'Human Resource Skill'
                        ),
                        (
                            'Training Skill'
                        ),
                        (
                            'Analytical Skill'
                        ),
                        (
                            'Computational Skill'
                        ),
                        (
                            'Engineering Skill'
                        ),
                        (
                            'Interpersonal Skill'
                        ),
                        (
                            'Management Skill'
                        )
                    "
                );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
