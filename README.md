The program connects to a database. 

The program calls a stored procedure, 'sp_GetUserDetails' using a parameter userId, 
(@uid) to be passed in.

The results are executed (cmd.ExecuteReader() ) and the variable (reader) is 
used to output the fields in the database. 
