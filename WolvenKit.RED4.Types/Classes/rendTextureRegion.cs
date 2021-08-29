using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendTextureRegion : ISerializable
	{
		private CName _name;
		private CBool _isStretch;
		private CArray<rendTextureRegionPart> _regionParts;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("isStretch")] 
		public CBool IsStretch
		{
			get => GetProperty(ref _isStretch);
			set => SetProperty(ref _isStretch, value);
		}

		[Ordinal(2)] 
		[RED("regionParts")] 
		public CArray<rendTextureRegionPart> RegionParts
		{
			get => GetProperty(ref _regionParts);
			set => SetProperty(ref _regionParts, value);
		}
	}
}
