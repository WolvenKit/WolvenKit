using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInputIconMappingJSON : RedBaseClass
	{
		private CName _id;
		private CName _part;
		private CBool _hold;

		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("part")] 
		public CName Part
		{
			get => GetProperty(ref _part);
			set => SetProperty(ref _part, value);
		}

		[Ordinal(2)] 
		[RED("hold")] 
		public CBool Hold
		{
			get => GetProperty(ref _hold);
			set => SetProperty(ref _hold, value);
		}
	}
}
