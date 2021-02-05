using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeLadderDescription : IScriptable
	{
		[Ordinal(0)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(1)]  [RED("normal")] public Vector4 Normal { get; set; }
		[Ordinal(2)]  [RED("up")] public Vector4 Up { get; set; }
		[Ordinal(3)]  [RED("topHeightFromPosition")] public CFloat TopHeightFromPosition { get; set; }
		[Ordinal(4)]  [RED("exitStepTop")] public CFloat ExitStepTop { get; set; }
		[Ordinal(5)]  [RED("verticalStepTop")] public CFloat VerticalStepTop { get; set; }
		[Ordinal(6)]  [RED("exitStepBottom")] public CFloat ExitStepBottom { get; set; }
		[Ordinal(7)]  [RED("verticalStepBottom")] public CFloat VerticalStepBottom { get; set; }
		[Ordinal(8)]  [RED("exitStepJump")] public CFloat ExitStepJump { get; set; }
		[Ordinal(9)]  [RED("verticalStepJump")] public CFloat VerticalStepJump { get; set; }
		[Ordinal(10)]  [RED("enterOffset")] public CFloat EnterOffset { get; set; }

		public gamestateMachineparameterTypeLadderDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
