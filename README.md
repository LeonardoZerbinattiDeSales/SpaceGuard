# SpaceGuard

## Integrantes do grupo

Caio Felipe Silva Rm 564615
Davi Tagawa Schincaglia Lima Lemos RM563457
Luis Guilherme Borges Silva Rm 566548
Leonardo Zerbinatti de Sales Rm562992
Vinícius Luis Exposito Morassi Garcia Rm563340

##  Sobre o Projeto

O SpaceGuard é uma aplicação desenvolvida para monitoramento ambiental utilizando dados de satélites. O sistema permite o gerenciamento de satélites, indicadores ambientais e alertas ambientais, contribuindo para a análise de informações relacionadas à qualidade ambiental e riscos climáticos.

##  Objetivo

Demonstrar a utilização de práticas DevOps e Cloud Computing através da implantação de uma aplicação ASP.NET Core containerizada utilizando Docker e PostgreSQL em uma máquina virtual Microsoft Azure.


##  Tecnologias Utilizadas

* ASP.NET Core 8
* C#
* Entity Framework Core
* PostgreSQL 16
* Docker
* Docker Compose
* Microsoft Azure
* GitHub

---
## Arquitetura

![Arquitetura SpaceGuard](docs/arquitetura-spaceguard.png)

##  Arquitetura da Solução

A aplicação é composta por dois containers Docker:

### Container 1 – Aplicação

* ASP.NET Core 8
* Porta 8080
* Responsável pela API e interface web

### Container 2 – Banco de Dados

* PostgreSQL 16
* Porta 5432
* Responsável pelo armazenamento persistente dos dados

---

## Infraestrutura

* Provedor Cloud: Microsoft Azure
* Sistema Operacional: Ubuntu 24.04 LTS
* Máquina Virtual: spaceguard-vm

---

## Funcionalidades

### Satélites

* Criar satélites
* Consultar satélites

### Indicadores Ambientais

* Criar indicadores
* Consultar indicadores

### Alertas Ambientais

* Criar alertas
* Consultar alertas

---

## Execução Local

```bash
docker compose up -d
```

Verificar containers:

```bash
docker ps
```

---

## Publicação

Aplicação publicada em ambiente Azure através de containers Docker.

---

## Equipe

Projeto desenvolvido para a disciplina de DevOps Tools & Cloud Computing – FIAP.

SpaceGuard © 2026
