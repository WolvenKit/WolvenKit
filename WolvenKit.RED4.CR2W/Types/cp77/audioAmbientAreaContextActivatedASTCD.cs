using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaContextActivatedASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] [RED("areaMixingContext")] public CName AreaMixingContext { get; set; }

		public audioAmbientAreaContextActivatedASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
