﻿namespace AnimalMatcher.Data.Models
{
    using AnimalMatcher.Common.Constants;
    using System.ComponentModel.DataAnnotations;

    public class Message
    {
        public int Id { get; set; }

        [Required]
        public int RecipientId { get; set; }

        public Pet Recipient { get; set; }

        [Required]
        public int SenderId { get; set; }

        public Pet Sender { get; set; }
        
        [MaxLength(MessageConstants.BodyMaxLength)]
        public string Body { get; set; }

    }
}
