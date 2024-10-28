using System;

namespace EF03.ReverseEngineering.Entities;

public partial class Event
{
    public int Id { get; set; }

    public string Title { get; set; }

    public DateTime StartAt { get; set; }

    public DateTime EndAt { get; set; }

    public int SpeakerId { get; set; }

    public virtual Speaker Speaker { get; set; }
}
