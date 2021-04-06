using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumihoUI.Models
{
    public class SelectListItem<T>
    {
        /// <summary>
        /// Gets or sets a value that indicate whether this <see cref="SelectListItem{T}" /> is selected.
        /// </summary>
        public bool Selected { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// Gets or sets text.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Gets or sets a value that indicate whether this <see cref="SelectListItem{T}" /> is disabled.
        /// </summary>
        public bool Disabled { get; set; }
        /// <summary>
        /// Represents the group of dropdown list items.
        /// </summary>
        public SelectListGroup Group { get; set; }
    }
}
