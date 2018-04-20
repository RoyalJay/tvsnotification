using System.Collections.Generic;


namespace tvsnotification.Models
{
  public class Tv
  {
    public string backdrop_path { get; set; }
    public List<object> created_by { get; set; }
    public List<int> episode_run_time { get; set; }
    public string first_air_date { get; set; }
    public List<TvGenre> genres { get; set; }
    public string homepage { get; set; }
    public int id { get; set; }
    public bool in_production { get; set; }
    public List<string> languages { get; set; }
    public string last_air_date { get; set; }
    public string name { get; set; }
    public List<TvNetwork> networks { get; set; }
    public int? number_of_episodes { get; set; }
    public int? number_of_seasons { get; set; }
    public List<string> origin_country { get; set; }
    public string original_language { get; set; }
    public string original_name { get; set; }
    public string overview { get; set; }
    public decimal popularity { get; set; }
    public string poster_path { get; set; }
    public List<object> production_companies { get; set; }
    public List<TvSeason> seasons { get; set; }
    public string status { get; set; }
    public string type { get; set; }
    public decimal vote_average { get; set; }
    public int vote_count { get; set; }
  }
}
