namespace NjForward.Modules {
    public class Server {
     
        public override string ToString() {
            return Name;
        }

        public string Name { get; set; }
        public string Host { get; set; }
        public int SshPort { get; set; }
        public string User { get; set; }
        public string Password { get; set; } 
        public string Guid { get; set; }
    }
}
