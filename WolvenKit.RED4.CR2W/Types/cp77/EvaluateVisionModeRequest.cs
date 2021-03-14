using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EvaluateVisionModeRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("mode")] public CEnum<gameVisionModeType> Mode { get; set; }

		public EvaluateVisionModeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
