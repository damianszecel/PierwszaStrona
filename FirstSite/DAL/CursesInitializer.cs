using FirstSite.Migrations;
using FirstSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace FirstSite.DAL
{
    public class CursesInitializer : MigrateDatabaseToLatestVersion<CursesContext, Configuration>
    {

        public static void SeedCursesData(CursesContext context)
        {
            var kategories = new List<Kategoria>
            {
                new Kategoria() {KategoriaId=1, KategoriaName="asp" , KategoriaDescription="asp desc" , IconName="asp.jpg"},
                new Kategoria() {KategoriaId=2, KategoriaName="java" , KategoriaDescription="java desc" , IconName="java.jpg"},
                new Kategoria() {KategoriaId=3, KategoriaName="php" , KategoriaDescription="php desc" , IconName="php.jpg"},
                new Kategoria() {KategoriaId=4, KategoriaName="html" , KategoriaDescription="html desc" , IconName="html.jpg"}
            };

            kategories.ForEach (k => context.Kategories.AddOrUpdate(k)) ;
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course() {CourseID=1, AuthorCourse="Damian", TitleCourse="Nauka", Price=20, Description="Opis"},
                new Course() {CourseID=2, AuthorCourse="Michal", TitleCourse="Sprzedaz", Price=150, Description="Opis"},
                new Course() {CourseID=3, AuthorCourse="Nikola", TitleCourse="Czytanie", Price=50, Description="Opis"},
                new Course() {CourseID=4, AuthorCourse="Damian", TitleCourse="Kierowanie", Price=150, Description="Opis"},
                new Course() {CourseID=5, AuthorCourse="Michal", TitleCourse="Opracowanie", Price=250, Description="Opis"},
                new Course() {CourseID=6, AuthorCourse="Damian", TitleCourse="Nauka", Price=510, Description="Opis"},
            };

            courses.ForEach(k => context.Courses.AddOrUpdate(k));
            context.SaveChanges();
            
        
        }
    }
}