using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IntercomControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("endingCall")] public CBool EndingCall { get; set; }
		[Ordinal(1)]  [RED("forceFollow")] public CBool ForceFollow { get; set; }
		[Ordinal(2)]  [RED("forceLookAt")] public entEntityID ForceLookAt { get; set; }
		[Ordinal(3)]  [RED("isCalling")] public CBool IsCalling { get; set; }
		[Ordinal(4)]  [RED("sceneStarted")] public CBool SceneStarted { get; set; }

		public IntercomControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
