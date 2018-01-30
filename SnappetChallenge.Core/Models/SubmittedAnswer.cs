﻿using System;

namespace SnappetChallenge.Core.Models
{
    public class SubmittedAnswer
    {
        public int SubmittedAnswerId { get; set; }
        public DateTime SubmitDateTime { get; set; }
        public int Correct { get; set; }
        public double Progress { get; set; }
        public int ExerciseId { get; set; }
        public string Difficulty { get; set; }
        public string Subject { get; set; }
        public string Domain { get; set; }
        public string LearningObjective { get; set; }
        public UserForSubmittedAnswer User { get; set; }
    }
}