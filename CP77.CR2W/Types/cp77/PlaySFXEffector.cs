using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlaySFXEffector : gameEffector
	{
		[Ordinal(0)]  [RED("activationSFXName")] public CName ActivationSFXName { get; set; }
		[Ordinal(1)]  [RED("deactivationSFXName")] public CName DeactivationSFXName { get; set; }
		[Ordinal(2)]  [RED("fireAndForget")] public CBool FireAndForget { get; set; }
		[Ordinal(3)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(4)]  [RED("startOnUninitialize")] public CBool StartOnUninitialize { get; set; }
		[Ordinal(5)]  [RED("stopActiveSfxOnDeactivate")] public CBool StopActiveSfxOnDeactivate { get; set; }
		[Ordinal(6)]  [RED("unique")] public CBool Unique { get; set; }

		public PlaySFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
