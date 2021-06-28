using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisualTagsAppearanceNamesPreset : ISerializable
	{
		private CArray<gameVisualTagsAppearanceNamesPreset_Entity> _presets;

		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<gameVisualTagsAppearanceNamesPreset_Entity> Presets
		{
			get => GetProperty(ref _presets);
			set => SetProperty(ref _presets, value);
		}

		public gameVisualTagsAppearanceNamesPreset(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
