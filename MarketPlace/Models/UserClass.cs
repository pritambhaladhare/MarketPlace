using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
CREATE TABLE[dbo].[tblUser] (

   [userID]        INT IDENTITY(1, 1) NOT NULL,

[username]      VARCHAR (50) NULL,
    [firstname]     VARCHAR (50) NULL,
    [lastname]      VARCHAR (50) NULL,
    [email]         VARCHAR (50) NULL,
    [password]      VARCHAR (50) NULL,
    [credential_ID] INT NULL,
    [imagepath] VARCHAR(50) NULL, 
    CONSTRAINT[PK_tblUser] PRIMARY KEY CLUSTERED ([userID] ASC)
);
*/

namespace MarketPlace.Models
{
    public class UserClass
    {
        public int  userID { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int credential_ID { get; set; }
        public string imagepath { get; set; }
    }
}