using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimInterpolator : IScriptable
	{
		[Ordinal(0)] [RED("interpolationMode")] public CEnum<inkanimInterpolationMode> InterpolationMode { get; set; }
		[Ordinal(1)] [RED("interpolationType")] public CEnum<inkanimInterpolationType> InterpolationType { get; set; }
		[Ordinal(2)] [RED("interpolationDirection")] public CEnum<inkanimInterpolationDirection> InterpolationDirection { get; set; }
		[Ordinal(3)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(4)] [RED("startDelay")] public CFloat StartDelay { get; set; }
		[Ordinal(5)] [RED("useRelativeDuration")] public CBool UseRelativeDuration { get; set; }
		[Ordinal(6)] [RED("isAdditive")] public CBool IsAdditive { get; set; }

		public inkanimInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
