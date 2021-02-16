using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Smart_Rifl_Bucket : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("progressBar")] public inkWidgetReference ProgressBar { get; set; }
		[Ordinal(2)] [RED("progressBarValue")] public inkWidgetReference ProgressBarValue { get; set; }
		[Ordinal(3)] [RED("targetIndicator")] public inkWidgetReference TargetIndicator { get; set; }
		[Ordinal(4)] [RED("lockedIndicator")] public inkWidgetReference LockedIndicator { get; set; }
		[Ordinal(5)] [RED("lockingIndicator")] public inkWidgetReference LockingIndicator { get; set; }
		[Ordinal(6)] [RED("data")] public gamesmartGunUITargetParameters Data { get; set; }
		[Ordinal(7)] [RED("lockingAnimationProxy")] public CHandle<inkanimProxy> LockingAnimationProxy { get; set; }

		public Crosshair_Smart_Rifl_Bucket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
