using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionPresetsOverridesResource : ISerializable
	{
		private CArray<physicsCollisionPresetOverride> _overrides;

		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<physicsCollisionPresetOverride> Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (CArray<physicsCollisionPresetOverride>) CR2WTypeManager.Create("array:physicsCollisionPresetOverride", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		public physicsCollisionPresetsOverridesResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
