using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionPresetsResource : ISerializable
	{
		private CArray<physicsCollisionPreset> _presets;

		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<physicsCollisionPreset> Presets
		{
			get
			{
				if (_presets == null)
				{
					_presets = (CArray<physicsCollisionPreset>) CR2WTypeManager.Create("array:physicsCollisionPreset", "presets", cr2w, this);
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

		public physicsCollisionPresetsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
