public class ProfileService : IProfileService
{
    protected DataContext _data;
    public ProfileService(DataContext context)
    {
         _data = context;
    }
    public void Add(Profile profile)
    {
        _data.Add(profile);
        _data.SaveChanges();
    }

    public Profile Find(int Id)
    {
        Profile p = new Profile();

        return p;
    }

    public IList<Profile> FindAll()
    {
        var profiles = _data.Profiles.ToList();
        return profiles;
    }

    public void Remove(int Id)
    {
        var profile = _data.Profiles.Find(Id);
        _data.Profiles.Remove(profile);
        _data.SaveChanges();
    }

    public void Update(Profile profile)
    {
        var profile_ = _data.Profiles.Find(profile.Id);

        profile_ = profile;

        _data.Profiles.Update(profile_);

        _data.SaveChanges();

    }
}