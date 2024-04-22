using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOpenModPlugin;

public class UserConnection
{
    // The primary key used to identify each connection.
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint ConnectionId { get; set; }
    
    // The user's ID.
    public string UserId { get; set; } = "";
	
    // The user's type.
    public string UserType { get; set; } = "";

    // The date/time of this connection record.
    public DateTime ConnectionTime { get; set; }
}