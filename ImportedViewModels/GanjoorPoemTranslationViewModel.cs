﻿using System;

namespace RMuseum.Models.Ganjoor.ViewModels
{
    /// <summary>
    /// poem translation view model
    /// </summary>
    public class GanjoorPoemTranslationViewModel
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// language
        /// </summary>
        public GanjoorLanguage Language { get; set; }

        /// <summary>
        /// poem id
        /// </summary>
        public int PoemId { get; set; }

        /// <summary>
        /// translated title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// published
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// comments or description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// might be empty in anonymous apis
        /// </summary>
        public Guid ContributerId { get; set; }

        /// <summary>
        /// contributer name - might be empty in anonymous apis
        /// </summary>
        public string ContributerName { get; set; }

        /// <summary>
        /// datetime
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// translated verses
        /// </summary>
        public GanjoorVerseTranslationViewModel[] TranslatedVerses { get; set; }
    }
}
