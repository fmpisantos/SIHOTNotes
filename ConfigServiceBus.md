# Configuration
## Install:
    - pgadmin4
    - postgres
    - https://gitlab.sihot.com/netdevelopers/net-nuget-packages

## Secrets ou appsettings
{
  "ConnectionStrings": {
    "Database": "server=localhost;database=sihot.servicebus;userid=postgres;password=@Abc123"
  }
}

## Migrações de schema (code first)
dotnet ef database update 

## Config no website
Username: admin
Password: @Abc123

criar APIKey copiar pq nao volta a ser disponibilizada
(aba0c18d-5dd4-4a3a-b628-7704b7ca105c)

Criar user para o servicebus ou escolher um para usar
Selecionar um dos products (ex: Adchieve)
siperform -> userdata guardar o productID associado ao user

Criar userdefinedevent para availability com o product id
Enable all hotels (HQ e test nao sao necessarios)

Room category master file com o product nos external ids (pode ser necessário restart do crossbow para aparecer o selecionado)

### Configurar dingus(Na dingus enable api key)
    - Sihot API Url: http://localhost:15009/ifs/SihotServices01
    - url: requestCatcher
    - registar user login criado e product id

### Crossbow.exe params:
    - /api/v1.0/dingus/push
    - -NAUTHTYPE ApiKey
    - -ProductID
    - Process admininstration -> "notificationApiKey" -> Criar no process vault

### Extra
Para correr localmente na SihotApiCOntext retirrar o Basic Http transport argument
