CREATE DATABASE DataStoreDB

USE DataStoreDB
CREATE TABLE Employee (
    ID_Employee INT IDENTITY(1,1) PRIMARY KEY,
    Name_Employee VARCHAR(50) NOT NULL,
    LastName_Employee VARCHAR(50) NOT NULL,
    RFC_Employee VARCHAR(13) NOT NULL UNIQUE,
    BornDate_Employee DATE NOT NULL,
    Status_Employee VARCHAR(8) DEFAULT 'NotSet' NOT NULL,
    CHECK (Status_Employee IN ('NotSet', 'Active', 'Inactive'))
);

-- Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB; AttachDbFilename=C:\Users\alegv\source\repos\DevCandidateTest-MichellAlejandroGarciaVargas\DevCandidateTest-MichellAlejandroGarciaVargas\Database\DataStoreDB.mdf; Database=DataStoreDB; Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context MyDbContext -Force
