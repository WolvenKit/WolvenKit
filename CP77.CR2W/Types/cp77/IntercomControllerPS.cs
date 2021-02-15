using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IntercomControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("isCalling")] public CBool IsCalling { get; set; }
		[Ordinal(104)] [RED("sceneStarted")] public CBool SceneStarted { get; set; }
		[Ordinal(105)] [RED("endingCall")] public CBool EndingCall { get; set; }
		[Ordinal(106)] [RED("forceLookAt")] public entEntityID ForceLookAt { get; set; }
		[Ordinal(107)] [RED("forceFollow")] public CBool ForceFollow { get; set; }

		public IntercomControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
