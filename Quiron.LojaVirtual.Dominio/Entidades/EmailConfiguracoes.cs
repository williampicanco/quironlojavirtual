namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class EmailConfiguracoes
    {
                   
        public bool UsarSsl = false;
        public string ServidorSmtp = "smtp.william.com.br";
        public int ServidorPorta = 587;
        public string Usuario = "william";
        public bool EscreverArquivo = false;
        public string PastaArquivo = @"c:\envioemail";
        public string De = "william@quiron.com.br";
        public string Para = "pedido@quiron.com.br";

    }
}