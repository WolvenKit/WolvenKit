using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldGINode : worldNode
	{
		private CResourceAsyncReference<CGIDataResource> _data;
		private CArrayFixedSize<CInt16> _location;

		[Ordinal(4)] 
		[RED("data")] 
		public CResourceAsyncReference<CGIDataResource> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(5)] 
		[RED("location", 3)] 
		public CArrayFixedSize<CInt16> Location
		{
			get => GetProperty(ref _location);
			set => SetProperty(ref _location, value);
		}
	}
}
