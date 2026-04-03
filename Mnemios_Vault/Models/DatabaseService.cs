// Arquivo: C:\th1eros\Ordakhan\Mnemios_Vault\Models\DatabaseService.cs
using System;
using Npgsql; // O driver que incluímos no .csproj
using Dapper; // O facilitador de queries

namespace Mnemios_Vault.Models
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string host, string user, string password, string database)
        {
            // No futuro, isso virá de uma variável de ambiente por segurança
            _connectionString = $"Host={host};Username={user};Password={password};Database={database}";
        }

        public void TestConnection()
        {
            try
            {
                using var connection = new NpgsqlConnection(_connectionString);
                connection.Open();
                Console.WriteLine("[+] Mnemos Vault: Conexão estabelecida com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[!] Erro de Segurança: Falha ao acessar o Vault. {ex.Message}");
            }
        }
    }
}