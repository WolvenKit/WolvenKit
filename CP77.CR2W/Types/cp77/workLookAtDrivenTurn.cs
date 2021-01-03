using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workLookAtDrivenTurn : workIEntry
	{
		[Ordinal(0)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(1)]  [RED("turnAngle")] public CInt32 TurnAngle { get; set; }
		[Ordinal(2)]  [RED("turnAnimName")] public CName TurnAnimName { get; set; }

		public workLookAtDrivenTurn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
