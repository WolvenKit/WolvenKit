using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CentaurShieldLookatController : AILookatTask
	{
		[Ordinal(0)] [RED("mainShieldLookat")] public CHandle<entLookAtAddEvent> MainShieldLookat { get; set; }
		[Ordinal(1)] [RED("mainShieldlookatActive")] public CBool MainShieldlookatActive { get; set; }
		[Ordinal(2)] [RED("currentLookatTarget")] public wCHandle<gameObject> CurrentLookatTarget { get; set; }
		[Ordinal(3)] [RED("shieldTarget")] public wCHandle<gameObject> ShieldTarget { get; set; }
		[Ordinal(4)] [RED("centaurBlackboard")] public CHandle<gameIBlackboard> CentaurBlackboard { get; set; }
		[Ordinal(5)] [RED("shieldTargetTimeStamp")] public CFloat ShieldTargetTimeStamp { get; set; }

		public CentaurShieldLookatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
