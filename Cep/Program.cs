using Newtonsoft.Json;

Console.WriteLine("Digite um cep: ");
string? cep = Console.ReadLine();
string? url = $"https://viacep.com.br/ws/{cep}/json/";
//string? url = $"https://viacep.com.br/ws/{cep}/xml/";

var resultado = new HttpClient().GetStringAsync(url).Result;

var cepObjeto = JsonConvert.DeserializeObject<CEP>(resultado);
var json = JsonConvert.SerializeObject(cepObjeto, Formatting.Indented);

Console.WriteLine(json);