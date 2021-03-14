using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAppearanceNameVisualTagsPreset : ISerializable
	{
		private CArray<gameAppearanceNameVisualTagsPreset_Entity> _presets;

		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<gameAppearanceNameVisualTagsPreset_Entity> Presets
		{
			get
			{
				if (_presets == null)
				{
					_presets = (CArray<gameAppearanceNameVisualTagsPreset_Entity>) CR2WTypeManager.Create("array:gameAppearanceNameVisualTagsPreset_Entity", "presets", cr2w, this);
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

		public gameAppearanceNameVisualTagsPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
