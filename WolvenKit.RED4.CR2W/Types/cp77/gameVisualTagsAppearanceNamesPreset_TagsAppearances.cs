using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisualTagsAppearanceNamesPreset_TagsAppearances : ISerializable
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

		public gameVisualTagsAppearanceNamesPreset_TagsAppearances(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
