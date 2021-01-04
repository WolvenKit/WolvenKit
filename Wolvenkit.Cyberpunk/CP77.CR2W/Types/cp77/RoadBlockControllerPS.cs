using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RoadBlockControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("isBlocking")] public CBool IsBlocking { get; set; }
		[Ordinal(1)]  [RED("nameForBlocking")] public TweakDBID NameForBlocking { get; set; }
		[Ordinal(2)]  [RED("nameForUnblocking")] public TweakDBID NameForUnblocking { get; set; }
		[Ordinal(3)]  [RED("negateAnimState")] public CBool NegateAnimState { get; set; }

		public RoadBlockControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
