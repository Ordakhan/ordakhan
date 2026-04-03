-- Arquivo: C:\th1eros\Ordakhan\Mnemios_Vault\schema.sql
-- Objetivo: Inteligência de Dados (Mnemos)

-- Tabela de Operadores (Pentesting Team)
CREATE TABLE IF NOT EXISTS users (
    id SERIAL PRIMARY KEY, 
    username TEXT UNIQUE NOT NULL, 
    role TEXT NOT NULL, -- Ex: 'Admin', 'Operator'
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabela de Arsenal (Ferramentas de Pentest)
CREATE TABLE IF NOT EXISTS pentest_tools (
    id SERIAL PRIMARY KEY,
    tool_name TEXT NOT NULL,
    category TEXT, -- Ex: Scanner, Exploit, Post-Exploitation
    binary_data BYTEA, -- Onde o binário do Zunn_Engine será guardado cifrado
    last_used TIMESTAMP
);

-- Tabela de Alvos (Targets coletados)
CREATE TABLE IF NOT EXISTS targets (
    id SERIAL PRIMARY KEY,
    ip_address TEXT,
    hostname TEXT,
    vulnerabilities JSONB, -- Formato flexível para logs de scans
    status TEXT -- Ex: 'Vulnerable', 'Secured'
);