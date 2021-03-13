using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWaitTimeASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] [RED("timeToWait")] public CFloat TimeToWait { get; set; }

		public audioWaitTimeASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
