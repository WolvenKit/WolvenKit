using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DlcDescriptionData : inkUserData
	{
		private CName _title;
		private CName _description;
		private CName _guide;
		private CName _imagePart;

		[Ordinal(0)] 
		[RED("title")] 
		public CName Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CName Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(2)] 
		[RED("guide")] 
		public CName Guide
		{
			get => GetProperty(ref _guide);
			set => SetProperty(ref _guide, value);
		}

		[Ordinal(3)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetProperty(ref _imagePart);
			set => SetProperty(ref _imagePart, value);
		}
	}
}
