namespace WorldCities.Server.Data
{
    public class ApiRegisterResult
    {
        
        public bool Success { get; set; }

        
        public required string Message { get; set; }

        
        public string? Token { get; set; }
    }
}
