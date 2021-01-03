using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeLadderDescription : IScriptable
	{
		[Ordinal(0)]  [RED("enterOffset")] public CFloat EnterOffset { get; set; }
		[Ordinal(1)]  [RED("exitStepBottom")] public CFloat ExitStepBottom { get; set; }
		[Ordinal(2)]  [RED("exitStepJump")] public CFloat ExitStepJump { get; set; }
		[Ordinal(3)]  [RED("exitStepTop")] public CFloat ExitStepTop { get; set; }
		[Ordinal(4)]  [RED("normal")] public Vector4 Normal { get; set; }
		[Ordinal(5)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(6)]  [RED("topHeightFromPosition")] public CFloat TopHeightFromPosition { get; set; }
		[Ordinal(7)]  [RED("up")] public Vector4 Up { get; set; }
		[Ordinal(8)]  [RED("verticalStepBottom")] public CFloat VerticalStepBottom { get; set; }
		[Ordinal(9)]  [RED("verticalStepJump")] public CFloat VerticalStepJump { get; set; }
		[Ordinal(10)]  [RED("verticalStepTop")] public CFloat VerticalStepTop { get; set; }

		public gamestateMachineparameterTypeLadderDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
