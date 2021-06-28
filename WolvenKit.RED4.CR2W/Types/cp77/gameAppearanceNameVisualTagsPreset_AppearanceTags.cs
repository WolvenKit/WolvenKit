using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAppearanceNameVisualTagsPreset_AppearanceTags : ISerializable
	{
		private CName _appearanceName;
		private redTagList _visualTags;

		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		[Ordinal(1)] 
		[RED("visualTags")] 
		public redTagList VisualTags
		{
			get => GetProperty(ref _visualTags);
			set => SetProperty(ref _visualTags, value);
		}

		public gameAppearanceNameVisualTagsPreset_AppearanceTags(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
