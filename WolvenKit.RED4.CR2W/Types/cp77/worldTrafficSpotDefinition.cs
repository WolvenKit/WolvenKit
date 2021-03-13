using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficSpotDefinition : ISerializable
	{
		[Ordinal(0)] [RED("length")] public CFloat Length { get; set; }
		[Ordinal(1)] [RED("direction")] public CEnum<worldTrafficSpotDirection> Direction { get; set; }

		public worldTrafficSpotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
