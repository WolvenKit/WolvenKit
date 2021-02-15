using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameAnimatedElementController : NetworkMinigameElementController
	{
		[Ordinal(12)] [RED("onConsumeAnimation")] public CName OnConsumeAnimation { get; set; }
		[Ordinal(13)] [RED("onSetContentAnimation")] public CName OnSetContentAnimation { get; set; }
		[Ordinal(14)] [RED("onHighlightOnAnimation")] public CName OnHighlightOnAnimation { get; set; }
		[Ordinal(15)] [RED("onHighlightOffAnimation")] public CName OnHighlightOffAnimation { get; set; }

		public NetworkMinigameAnimatedElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
