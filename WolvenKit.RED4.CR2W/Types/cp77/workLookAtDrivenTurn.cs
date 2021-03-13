using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workLookAtDrivenTurn : workIEntry
	{
		[Ordinal(2)] [RED("turnAngle")] public CInt32 TurnAngle { get; set; }
		[Ordinal(3)] [RED("turnAnimName")] public CName TurnAnimName { get; set; }
		[Ordinal(4)] [RED("blendTime")] public CFloat BlendTime { get; set; }

		public workLookAtDrivenTurn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
