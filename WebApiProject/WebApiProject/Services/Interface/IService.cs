namespace WebApiProject.Services.Interface
{
    public interface IService
    {
	 Task<string> Getallcountries();
		Task<string> Getbyregion(string region);
		Task<string> GetbyName(string name);
		Task<string> Getfullname(string fullname);
		Task<string> Getalphacode(string code);
		Task<string> Getbycurrency(string currency);
		Task<string> Getbylanguage(string langCode);
		Task<string> Getbycapital(string capitalCity);
		Task<string> GetbyCallcode(string callingcode);
		Task<string> Getbyregionalbloc(string regionalBloc);
	}
}
