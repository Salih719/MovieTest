using System.Collections.Generic;
using System.Linq;
using MovieTest.Models;

namespace MovieTest.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>() {
                new Movie() { Id=1, Name="Wish Dragon", ShortDescription="Wish Dragon", Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>", ImageUrl="10.jpg", CategoryId =1},

                new Movie() { Id=2, Name="Luka", ShortDescription="Luka", Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>", ImageUrl="20.jpg", CategoryId =2},

                new Movie() { Id=3, Name="Cruella", ShortDescription="Cruella", Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>", ImageUrl="30.jpg", CategoryId =2},

                new Movie() { Id=4, Name="Monster Pets", ShortDescription="Monster Pets", Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>", ImageUrl="40.jpg", CategoryId =3},

                new Movie() { Id=5, Name="Fight Club", ShortDescription="Fight Club", Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>", ImageUrl="50.jpg", CategoryId =3}
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}