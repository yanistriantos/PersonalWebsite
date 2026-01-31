
## cybersecurity Tools & Resources Hub

---

## 1. УПРАВЛЕНИЕ НА ПРОЕКТА


## 2. СПЕЦИФИКАЦИЯ 

### 2.1 Функционалности
- **Генератор на пароли** - Генерира сигурни случайни пароли
- **Проверка на силата на паролите** - Анализира и класифицира паролите
- **Форум** - Публикации с CRUD операции и сортиране
- **Изтегляния** - Ресурси и документи за сигурност
- **За мен** - Автобиография и технически умения

### 2.2 Технологии
- **Backend:** ASP.NET Core MVC (.NET 10.0)
- **Frontend:** HTML5, CSS3, JavaScript, jQuery, Bootstrap 5
- **База данни:** MySQL (Entity Framework Core)
- **Ajax:** Асинхронни CRUD операции

### 2.3 База данни
**Таблица Comments:**
- Id (Primary Key)
- Username
- Message
- CreatedDate
- SessionId

---

## 3. ИНСТАЛАЦИЯ

### 3.1 Изисквания
- .NET 10.0 SDK
- MySQL Server

### 3.2 Стъпки
1. Клонирайте: `git clone https://github.com/yanistriantos/PersonalWebsite.git`
2. Създайте база данни `PersonalWebsiteDb` в MySQL
3. Изпълнете `database_setup.sql`
4. Настройте connection string в `appsettings.json`
5. Стартирайте: `dotnet run`

---

## 4. СТРУКТУРА НА ПРОЕКТА
PersonalWebsite/
├── Controllers/ # MVC контролери
├── Views/ # Razor views
├── Models/ # Data models
├── Data/ # Database context
└── wwwroot/ # Static files

## Инсталация

1. Клонирайте репозитория:
git clone https://github.com/yanistriantos/PersonalWebsite.git
