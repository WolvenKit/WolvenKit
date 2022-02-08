using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioWwiseIgnoredNames : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("ignoredNames")] 
		public CArray<CName> IgnoredNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioWwiseIgnoredNames()
		{
			IgnoredNames = new();
		}
	}
}
