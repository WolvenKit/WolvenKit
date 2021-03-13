using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionPresetsOverridesResource : ISerializable
	{
		[Ordinal(0)] [RED("overrides")] public CArray<physicsCollisionPresetOverride> Overrides { get; set; }

		public physicsCollisionPresetsOverridesResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
