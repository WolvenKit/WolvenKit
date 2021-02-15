using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CameraDeadBodyData : IScriptable
	{
		[Ordinal(0)] [RED("dataType")] public CEnum<EGameSessionDataType> DataType { get; set; }
		[Ordinal(1)] [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(2)] [RED("bodyID")] public entEntityID BodyID { get; set; }

		public CameraDeadBodyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
