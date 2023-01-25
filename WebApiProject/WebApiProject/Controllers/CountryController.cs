using Microsoft.AspNetCore.Mvc;
using WebApiProject.Services.Interface;

namespace WebApi.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class CountryController : ControllerBase
	{
		private readonly IService _service;

		
		public CountryController(ILogger<CountryController> logger,IService service)
		{
			_service = service;
		}

		[HttpGet("allcountry")]
		public async Task<string> Getallcountries()
		{
			var obj =await _service.Getallcountries();
			return obj;
		}	

		[HttpGet("region/{region}")]
		public async Task<string> Getbyregion(string region)
		{
			var obj = await _service.Getbyregion(region);
			return obj;
		}
		[HttpGet("name/{name}")]
		public async Task<string> GetbyName(string name)
		{

			var obj = await _service.GetbyName(name);
			return obj;
		}
		[HttpGet("fname/{fullname}")]
		public async Task<string> Getfullname(string fullname)
		{
			var obj = await _service.Getfullname(fullname);
			return obj;
		}
		[HttpGet("alpha/{code}")]
		public async Task<string> Getalphacode(string code)
		{
			var obj = await _service.Getalphacode(code);
			return obj;
		}
		[HttpGet("currency/{currency}")]
		public async Task<string> Getbycurrency(string currency)
		{
			var obj = await _service.Getbycurrency(currency);
			return obj;
		}
		[HttpGet("language/{langCode}")]
		public async Task<string> Getbylanguage(string langCode)
		{
			var obj = await _service.Getbylanguage(langCode);
			return obj;
		}
		[HttpGet("capital/{capitalCity}")]
		public async Task<string> Getbycapital(string capitalCity)
		{
			var obj = await _service.Getbycapital(capitalCity);
			return obj;
		}
		[HttpGet("callingcode/{callingcode}")]
		public async Task<string> GetbyCallcode(string callingcode)
		{
			var obj = await _service.GetbyCallcode(callingcode);
			return obj;
		}
		[HttpGet("regionalbloc/{regionalBloc}")]
		public async Task<string> Getbyregionalbloc(string regionalBloc)
		{
			var obj = await _service.Getbyregionalbloc(regionalBloc);
			return obj;
		}
		
	}
}