# Demo project
So this is a demo project, generated with aspboilerplate and optimized to build & run under FreeBSD.

Key changes were in database migration scripts - it was required to switch from MS SQL Server to PostgreSQL, but EF code generation had not worked well.
Also I turned off HTTPS with self-signed certs, because it doesn't work too.

It was created for my article:
[How to code with .NET on FreeBSD](https://teletype.in/@alex0x08/dotnet-on-freebsd-yeee) (Russian only for now)

# Демо проект
Это демо проект, сгенерированный [aspnetboilerplate](https://aspnetboilerplate.com) и переделанный для сборки и запуска под FreeBSD.

Основные изменения были в скриптах миграции данных, поскольку требовалось переключить проект с MS SQL Server на PostgreSQL, но механизм кодогенерации из моделей в EF не сработал.
Также я отключил запуск HTTPS с самоподписанным сертификатом, поскольку он тоже нормально не работал.

Сделан для статьи [Разработка на .NET под FreeBSD](https://teletype.in/@alex0x08/dotnet-on-freebsd-yeee)



# Important

Issues of this repository are tracked on https://github.com/aspnetboilerplate/aspnetboilerplate. Please create your issues on https://github.com/aspnetboilerplate/aspnetboilerplate/issues.

# Introduction

This is a template to create **ASP.NET Core MVC / Angular** based startup projects for [ASP.NET Boilerplate](https://aspnetboilerplate.com/Pages/Documents). It has 2 different versions:

1. [ASP.NET Core MVC & jQuery](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core) (server rendered multi-page application).
2. [ASP.NET Core & Angular](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular) (single page application).
 
User Interface is based on [AdminLTE theme](https://github.com/ColorlibHQ/AdminLTE).
 
# Download

Create & download your project from https://aspnetboilerplate.com/Templates

# Screenshots

#### Sample Dashboard Page
![](_screenshots/module-zero-core-template-ui-home.png)

#### User Creation Modal
![](_screenshots/module-zero-core-template-ui-user-create-modal.png)

#### Login Page

![](_screenshots/module-zero-core-template-ui-login.png)

# Documentation

* [ASP.NET Core MVC & jQuery version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core)
* [ASP.NET Core & Angular  version.](https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Angular)

# License

[MIT](LICENSE).
