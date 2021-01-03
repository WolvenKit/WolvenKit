using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questMovePuppetNodeParams : questAICommandParams
	{
		[Ordinal(0)]  [RED("moveOnSplineParams")] public CHandle<questMoveOnSplineParams> MoveOnSplineParams { get; set; }
		[Ordinal(1)]  [RED("moveToParams")] public CHandle<questMoveToParams> MoveToParams { get; set; }
		[Ordinal(2)]  [RED("moveType")] public CEnum<questMoveType> MoveType { get; set; }
		[Ordinal(3)]  [RED("otherParams")] public CHandle<questAICommandParams> OtherParams { get; set; }
		[Ordinal(4)]  [RED("repeatCommandOnInterrupt")] public CBool RepeatCommandOnInterrupt { get; set; }

		public questMovePuppetNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
