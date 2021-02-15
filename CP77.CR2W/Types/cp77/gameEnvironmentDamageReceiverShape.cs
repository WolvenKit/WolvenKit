using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverShape : ISerializable
	{
		[Ordinal(0)] [RED("transform")] public Transform Transform { get; set; }

		public gameEnvironmentDamageReceiverShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
