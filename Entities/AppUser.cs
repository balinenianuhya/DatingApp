namespace DatingApp.Entities
{
    public class AppUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string DisplayName { get; set; }
        public required string Email { get; set; }

        public byte[] PasswordHash { get; set; }  = Array.Empty<byte>();
        
        public byte[] PasswordSalt{ get; set; }= Array.Empty<byte>();
    }
}
