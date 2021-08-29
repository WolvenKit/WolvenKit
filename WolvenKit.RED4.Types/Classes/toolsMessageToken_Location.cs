using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsMessageToken_Location : toolsIMessageToken
	{
		private CHandle<toolsIMessageLocation> _location;

		[Ordinal(0)] 
		[RED("location")] 
		public CHandle<toolsIMessageLocation> Location
		{
			get => GetProperty(ref _location);
			set => SetProperty(ref _location, value);
		}
	}
}
