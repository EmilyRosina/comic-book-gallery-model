﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel.Models
{
	public class ComicBook
	{
		// [EF naming options] ID, ComicBookId, ComicBookID
		public int Id { get; set; }
		public string SeriesTitle { get; set; }
		public int IssueNumber { get; set; }
		public string Description { get; set; }
		public DateTime PublishedOn { get; set; }

	}
}
