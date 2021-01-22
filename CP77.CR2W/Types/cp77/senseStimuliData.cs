using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseStimuliData : IScriptable
	{
		[Ordinal(0)]  [RED("aggressiveValue")] public CFloat AggressiveValue { get; set; }
		[Ordinal(1)]  [RED("curiosityValue")] public CFloat CuriosityValue { get; set; }
		[Ordinal(2)]  [RED("disgustValue")] public CFloat DisgustValue { get; set; }
		[Ordinal(3)]  [RED("fearValue")] public CFloat FearValue { get; set; }
		[Ordinal(4)]  [RED("funnyValue")] public CFloat FunnyValue { get; set; }
		[Ordinal(5)]  [RED("interval")] public CFloat Interval { get; set; }
		[Ordinal(6)]  [RED("isReactionStim")] public CBool IsReactionStim { get; set; }
		[Ordinal(7)]  [RED("isSecurityAreaExclusive")] public CBool IsSecurityAreaExclusive { get; set; }
		[Ordinal(8)]  [RED("joyValue")] public CFloat JoyValue { get; set; }
		[Ordinal(9)]  [RED("sadValue")] public CFloat SadValue { get; set; }
		[Ordinal(10)]  [RED("shockValue")] public CFloat ShockValue { get; set; }
		[Ordinal(11)]  [RED("stimPriority")] public CInt32 StimPriority { get; set; }
		[Ordinal(12)]  [RED("surpriseValue")] public CFloat SurpriseValue { get; set; }

		public senseStimuliData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
