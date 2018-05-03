﻿using System;

namespace Data.Entities.Common.Redmine
{
    public class Issue : IEquatable<Issue>, IComparable, IComparable<Issue>
    {
        public int Id { get; set; }

        public User AssignedTo { get; set; }

        public Project Project { get; set; }

        public Status Status { get; set; }

        public Priority Priority { get; set; }

        public Tracker Tracker { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int CompareTo(Issue other)
        {
            return Id.CompareTo(other.Id);
        }

        public int CompareTo(object obj)
        {
            return CompareTo((Issue)obj);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Issue);
        }

        public bool Equals(Issue other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Subject;
        }
    }
}
