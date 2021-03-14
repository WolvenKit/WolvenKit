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
			get
			{
				if (_presets == null)
				{
					_presets = (CArray<gameVisualTagsAppearanceNamesPreset_Entity>) CR2WTypeManager.Create("array:gameVisualTagsAppearanceNamesPreset_Entity", "presets", cr2w, this);
				}
				return _presets;
			}
			set
			{
				if (_presets == value)
				{
					return;
				}
				_presets = value;
				PropertySet(this);
			}
		}

		public gameVisualTagsAppearanceNamesPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
