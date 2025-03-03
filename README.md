# MakeOrder


Инструкция для запуска:
1. Скачать SQL Server 2022 Developer.
2. Установить для MakeOrder.DB:
  Microsoft.EntityFrameworkCore 9.0.2,
  Microsoft.EntityFrameworkCore.SqlServer 9.0.2,
  Microsoft.EntityFrameworkCore.Tools 9.0.2
3. Установить для MakeOrderWebApp Microsoft.EntityFrameworkCore.Design 9.0.2.
4. Открыть Packeg Manager Console, выбрать MakeOrder.DB и прописать Add-Migration InitDatabase -context DatabaseContext.
