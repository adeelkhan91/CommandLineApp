using WebApiProject.Services.Interface;

namespace WebApiProject.Services.Class
{
    public class Service : IService
    {
		public string Data => throw new NotImplementedException();

		public async Task<string> Getallcountries()
		{
			try { 

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/all").Result;

			var data = await response.Content.ReadAsStringAsync();
			return data;
			}catch(Exception ex) { 
			return ex.ToString();
			}
		}
		public async Task<string> Getbyregion(string region)
		{
			try
			{
				HttpClient client = new HttpClient();
				HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/region/" + region).Result;

				var data = await response.Content.ReadAsStringAsync();
				return data;
			}catch(Exception ex)
			{
				return ex.ToString();
			}
		}
		public async Task<string> GetbyName(string name)
		{
			try
			{
				HttpClient client = new HttpClient();
				HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/name/" + name).Result;

				var data = await response.Content.ReadAsStringAsync();
				return data;
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}
		public async Task<string> Getfullname(string fullname)
		{
			try
			{
				HttpClient client = new HttpClient();
				var url = "https://restcountries.com/v3.1/name/" + fullname + "?fullText=true";
				HttpResponseMessage response = client.GetAsync(url).Result;

				var data = await response.Content.ReadAsStringAsync();
				return data;
			}
			catch(Exception ex)
			{
				return ex.ToString();
			}
		}
		public async Task<string> Getalphacode(string code)
		{
			try
			{
				HttpClient client = new HttpClient();
				HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/alpha/" + code).Result;

				var data = await response.Content.ReadAsStringAsync();
				return data;
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}
		public async Task<string> Getbycurrency(string currency)
		{
			try
			{
				HttpClient client = new HttpClient();
				HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/currency/" + currency).Result;

				var data = await response.Content.ReadAsStringAsync();
				return data;
			}catch(Exception ex)
			{
				return ex.ToString();
			}
		}
		public async Task<string> Getbylanguage(string langCode)
		{
			try
			{
				HttpClient client = new HttpClient();
				HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/lang/" + langCode).Result;

				var data = await response.Content.ReadAsStringAsync();
				return data;
			}
			catch(Exception ex)
			{
				return ex.ToString();
			}
		}
		public async Task<string> Getbycapital(string capitalCity)
		{
			try
			{
				HttpClient client = new HttpClient();
				HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/capital/" + capitalCity).Result;

				var data = await response.Content.ReadAsStringAsync();
				return data;
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}
		public async Task<string> GetbyCallcode(string callingcode)
		{
			try
			{
				HttpClient client = new HttpClient();
				HttpResponseMessage response = client.GetAsync("https://restcountries.com/v2/callingcode/" + callingcode).Result;

				var data = await response.Content.ReadAsStringAsync();
				return data;

			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}
		public async Task<string> Getbyregionalbloc(string regionalBloc)
		{
			try
			{
				HttpClient client = new HttpClient();
				HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/regionalbloc/" + regionalBloc).Result;

				var data = await response.Content.ReadAsStringAsync();
				return data;
			}
			catch(Exception ex)
			{
				return ex.ToString();
			}
		}


	}
}
