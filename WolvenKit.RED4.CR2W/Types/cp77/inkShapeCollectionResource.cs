using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkShapeCollectionResource : CResource
	{
		private CArray<inkShapePreset> _presets;

		[Ordinal(1)] 
		[RED("presets")] 
		public CArray<inkShapePreset> Presets
		{
			get
			{
				if (_presets == null)
				{
					_presets = (CArray<inkShapePreset>) CR2WTypeManager.Create("array:inkShapePreset", "presets", cr2w, this);
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

		public inkShapeCollectionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
