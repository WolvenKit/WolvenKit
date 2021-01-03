using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Move : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)]  [RED("movement")] public CHandle<gameTransformAnimation_Movement> Movement { get; set; }
		[Ordinal(1)]  [RED("startPositionEvaluator")] public CHandle<gameTransformAnimation_Position> StartPositionEvaluator { get; set; }
		[Ordinal(2)]  [RED("targetPositionEvaluator")] public CHandle<gameTransformAnimation_Position> TargetPositionEvaluator { get; set; }

		public gameTransformAnimation_Move(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
