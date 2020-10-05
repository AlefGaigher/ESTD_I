class Contato
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public Contato(){ }
        public Contato(string name, string email, string telephone)
        {
            this.Name = name;
            this.Email = email;
            this.Telephone = telephone;
        }

        public override string ToString()
        {
            return "Nome: "+ this.Name + ", Telefone: " + this.Telephone + ", Email: " + this.Email;
        }
    }