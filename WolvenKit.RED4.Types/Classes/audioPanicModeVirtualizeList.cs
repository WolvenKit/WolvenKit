using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPanicModeVirtualizeList : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioPanicModeVirtualizeList()
		{
			Tags = new();
		}
	}
}
