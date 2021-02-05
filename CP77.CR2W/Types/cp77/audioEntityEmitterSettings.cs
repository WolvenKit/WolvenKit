using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioEntityEmitterSettings : CVariable
	{
		[Ordinal(0)]  [RED("emitterName")] public CName EmitterName { get; set; }
		[Ordinal(1)]  [RED("positionName")] public CName PositionName { get; set; }
		[Ordinal(2)]  [RED("emitterDecorators")] public CArray<CName> EmitterDecorators { get; set; }
		[Ordinal(3)]  [RED("keepAlive")] public CBool KeepAlive { get; set; }
		[Ordinal(4)]  [RED("isObjectPerPositionEmitter")] public CBool IsObjectPerPositionEmitter { get; set; }

		public audioEntityEmitterSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
