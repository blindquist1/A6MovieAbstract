using ApplicationTemplate.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Context
{
    public class MediaContext
    {
        public List<Movie> Movies { get; set; }
        public List<Show> Shows { get; set; }
        public List<Video> Videos { get; set; }
        
        string _file;
        
        int _id;
        
        string _title;

        //Simulates loading up a file
        public MediaContext(string type) //Simulates loading up a file
        {
            if (type == "Movies")
            {
                MoviesRead();
                MoviesDisplay();
            }
            else if (type == "Shows")
            {
                ShowsRead();
                ShowsDisplay();
            }
            else if (type == "Videos")
            {
                VideosRead();
                VideosDisplay();
            }
        }
        private void MoviesRead()
        {
            _file = $"{Environment.CurrentDirectory}/data/movies.csv";
            string genres;
            Movies = new List<Movie>();

            // to populate the object with data, read from the data file
            StreamReader sr = new StreamReader(_file);

            // first line contains column headers
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                //assuming no comma (,) in title to keep things simple
                // movie details are separated with comma(,)
                string[] movieDetails = line.Split(',');
                // 1st array element contains movie id
                _id = int.Parse(movieDetails[0]);
                // 2nd array element contains movie title
                _title = movieDetails[1];
                // 3rd array element contains movie genre(s)
                // replace "|" with ", "
                genres = movieDetails[2].Replace("|", ", ");

                Movies.Add(new Movie() { Id = _id, Title = _title, Genres = new string[] { genres } });
            }
            // close file when done
            sr.Close();
        }

        private void MoviesDisplay()
        {
            foreach (Movie movie in Movies)
            {
                movie.Display();
            }
        }

        private void ShowsRead()
        {
            _file = $"{Environment.CurrentDirectory}/data/shows.csv";
            int season;
            int episode;
            string writers;

            Shows = new List<Show>();

            // to populate the object with data, read from the data file
            StreamReader sr = new StreamReader(_file);
            // first line contains column headers
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                //assuming no comma (,) in title to keep things simple
                // show details are separated with comma(,)
                string[] showDetails = line.Split(',');
                // 1st array element contains show id
                _id = int.Parse(showDetails[0]);
                // 2nd array element contains show title
                _title = showDetails[1];
                // 3rd array element contains show season
                season = int.Parse(showDetails[2]);
                // 4th array element contains show episode
                episode = int.Parse(showDetails[3]);
                // 5th array element contains show writers(s)
                // replace "|" with ", "
                writers = showDetails[4].Replace("|", ",");

                Shows.Add(new Show() { Id = _id, Title = _title, Season = season, Episode = episode, Writers = new string[] { writers } });
            }
            // close file when done
            sr.Close();
        }
        private void ShowsDisplay()
        {
            foreach (Show show in Shows)
            {
                show.Display();
            }
        }
        private void VideosRead()
        {
            _file = $"{Environment.CurrentDirectory}/data/videos.csv";
            string formats;
            int length;
            int[] regions;
            //string regions;

            Videos = new List<Video>();

            // to populate the object with data, read from the data file
            StreamReader sr = new StreamReader(_file);
            // first line contains column headers
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                //assuming no comma (,) in title to keep things simple
                // video details are separated with comma(,)
                string[] videoDetails = line.Split(',');
                // 1st array element contains video id
                _id = int.Parse(videoDetails[0]);
                // 2nd array element contains video title
                _title = videoDetails[1];
                // 3rd array element contains video format
                formats = videoDetails[2].Replace("|", ",");
                // 4th array element contains video length
                length = int.Parse(videoDetails[3]);
                // 5th array element contains video region(s)
                // replace "|" with ", "
                regions = videoDetails[4].Split('|').Select(x => int.Parse(x)).ToArray();

                Videos.Add(new Video() { Id = _id, Title = _title, Length = length, Regions = regions, Formats = new string[] { formats } }) ;
            }
            // close file when done
            sr.Close();
        }
        private void VideosDisplay()
        {
            foreach (Video video in Videos)
            {
                video.Display();
            }
        }
    }
}
