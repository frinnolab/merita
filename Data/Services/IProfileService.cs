interface IProfileService
{
    void Add(Profile profile);
    void Update(Profile profile);
    void Remove(int Id);
    Profile Find(int Id);
    IList<Profile> FindAll();

}