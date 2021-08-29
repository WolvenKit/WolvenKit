using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisualTagsAppearanceNamesPreset_TagsAppearances : ISerializable
	{
		private CName _visualTagHash;
		private CArray<CName> _appearanceNames;

		[Ordinal(0)] 
		[RED("visualTagHash")] 
		public CName VisualTagHash
		{
			get => GetProperty(ref _visualTagHash);
			set => SetProperty(ref _visualTagHash, value);
		}

		[Ordinal(1)] 
		[RED("appearanceNames")] 
		public CArray<CName> AppearanceNames
		{
			get => GetProperty(ref _appearanceNames);
			set => SetProperty(ref _appearanceNames, value);
		}
	}
}
