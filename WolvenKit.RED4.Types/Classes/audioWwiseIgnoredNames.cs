using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioWwiseIgnoredNames : audioAudioMetadata
	{
		private CArray<CName> _ignoredNames;

		[Ordinal(1)] 
		[RED("ignoredNames")] 
		public CArray<CName> IgnoredNames
		{
			get => GetProperty(ref _ignoredNames);
			set => SetProperty(ref _ignoredNames, value);
		}
	}
}
