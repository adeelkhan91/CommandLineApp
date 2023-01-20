using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using WebApiProject;
using WebApiProject.Model;

namespace WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CountryController : ControllerBase
	{
	
		[HttpGet("allcountry")]
		public async Task<string> Getallcountries()
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/all").Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}	

		[HttpGet("region/{region}")]
		public async Task<string> Getbyregion(string region)
		{

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/region/" + region).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		[HttpGet("name/{name}")]
		public async Task<string> GetbyName(string name)
		{

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/name/" + name).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		[HttpGet("fname/{fullname}")]
		public async Task<string> Getfullname(string fullname)
		{

			HttpClient client = new HttpClient();
			var url = "https://restcountries.com/v3.1/name/" + fullname + "?fullText=true";
			HttpResponseMessage response = client.GetAsync(url).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		[HttpGet("alpha/{code}")]
		public async Task<string> Getalphacode(string code)
		{

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/alpha/" + code).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		[HttpGet("currency/{currency}")]
		public async Task<string> Getbycurrency(string currency)
		{

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/currency/" + currency).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		[HttpGet("language/{langCode}")]
		public async Task<string> Getbylanguage(string langCode)
		{

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/lang/" + langCode).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		[HttpGet("capital/{capitalCity}")]
		public async Task<string> Getbycapital(string capitalCity)
		{

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/capital/" + capitalCity).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		[HttpGet("callingcode/{callingcode}")]
		public async Task<string> GetName(string callingcode)
		{

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/callingcode/" + callingcode).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		[HttpGet("regionalbloc/{regionalBloc}")]
		public async Task<string> Getbyregionalbloc(string regionalBloc)
		{

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://restcountries.com/v3.1/regionalbloc/" + regionalBloc).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		[HttpGet("ip/{ipadress}")]
		public async Task<string> Getbyip(string ipadress)
		{

			HttpClient client = new HttpClient();
			HttpResponseMessage response = client.GetAsync("https://geo.ipify.org/api/v1?apiKey=at_Y6YoKAMjsUQEY3KHyEH7vZ8oCVvAp&ipAddress=	" + ipadress).Result;

			var data = response.Content.ReadAsStringAsync().Result;
			return data;
		}
		
	}
}