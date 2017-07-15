#------------------
# DB SETUP
#------------------

Install MySQL Community, MySQL Workbench and MySQL Command Line Client

Create a mysql user 'centipede' using the password 'v0t3m@g@_db'

Open a text editor and Run as Administrator 

open 'C:\ProgramData\MySQL\MySQL Server 5.7\my.ini'

add 'lower_case_table_names=2' at bottom of file (without the quotes) save/close
(this allows CapitalsInTableNames)