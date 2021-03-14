using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialResource : CResource
	{
		[Ordinal(1)] [RED("staticFriction")] public CFloat StaticFriction { get; set; }
		[Ordinal(2)] [RED("dynamicFriction")] public CFloat DynamicFriction { get; set; }
		[Ordinal(3)] [RED("restitution")] public CFloat Restitution { get; set; }
		[Ordinal(4)] [RED("frictionMode")] public CEnum<physicsMaterialFriction> FrictionMode { get; set; }
		[Ordinal(5)] [RED("density")] public CFloat Density { get; set; }
		[Ordinal(6)] [RED("tags")] public physicsMaterialTags Tags { get; set; }
		[Ordinal(7)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(8)] [RED("id")] public CUInt64 Id { get; set; }

		public physicsMaterialResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
