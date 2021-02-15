using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEnvironmentDamageReceiverBox : gameEnvironmentDamageReceiverShape
	{
		[Ordinal(1)] [RED("dimensions")] public Vector3 Dimensions { get; set; }

		public gameEnvironmentDamageReceiverBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
