# PasswordHashViewer
Программа для просмотра хэшей паролей пользователей 1С
Использование в файловом варианте:
• указать путь к базе данных

Использование в клиент-серверном варианте: 
• указать адрес сервера
• указать наименования экземпляра сервера
• указать название базы данных
• указать логин пользователя с правами на чтение базы
• указать его пароль

При клике по строке правой кнопкой мыши можно скопировать первый или второй хэш

При нажатии на кнопку "Открыть сайт для расшифровки хэшей" в браузере откроется ссылка https://hashkiller.co.uk/sha1-decrypter.aspx
На этом сервисе вы можете проверить, не содержится ли пароль с таким хэшем в его базе данных.

Программа создавалась как форк проекта https://github.com/alekseybochkov/PasswordChanger1C. По сравнению с ним у этой программы:
• более удобный интерфейс для работы с SQL базами
• есть возможность копирования хэшей в буфер обмена 
• исправлены некоторые ошибки в коде при работе с файловыми базами
• убрана возможность установки нового пароля - слишком опасная была функция
