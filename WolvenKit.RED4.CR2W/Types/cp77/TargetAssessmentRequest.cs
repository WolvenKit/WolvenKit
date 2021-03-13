using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetAssessmentRequest : ScriptableDeviceAction
	{
		[Ordinal(25)] [RED("targetToAssess")] public wCHandle<gameObject> TargetToAssess { get; set; }

		public TargetAssessmentRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
