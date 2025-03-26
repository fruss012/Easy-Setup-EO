# Easy Setup EO

**Easy Setup EO** is a Windows Forms application designed to simplify the configuration of the Eudemons server. This tool allows you to easily update server settings (such as server name, IP, ports) and database connection details across multiple configuration files in both the AccountServer and GameServer folders. It also includes file conversion features for generating client connection files like `oem.dat`, as well as converting `shell.ini` to `shell.dat` and updating `port.dat`.

## Features

- **Server Configuration:**
  - Update server name and IP.
  - Update various port values (login, NPC, message) across configuration files.
  - Automatically update keys in files such as `account.ini`, `config.ini`, `gameserver.cfg`, and `shell.ini`.

- **Database Configuration:**
  - Configure database connection settings (database name, username, password) in multiple files.
  - Updates occur in files like `config.ini`, `AuthorizeDB.cfg`, and `gameserver.cfg`.

- **File Conversions & Generation:**
  - Convert `shell.ini` to a binary `shell.dat` file.
  - Generate a plain-text `port.dat` file containing the message port.
  - Create an `oem.dat` file for client connection, built using the updated server name, IP, and login port.

