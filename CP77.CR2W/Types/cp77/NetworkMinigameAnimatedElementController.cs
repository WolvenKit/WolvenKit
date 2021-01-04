using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameAnimatedElementController : NetworkMinigameElementController
	{
		[Ordinal(0)]  [RED("onConsumeAnimation")] public CName OnConsumeAnimation { get; set; }
		[Ordinal(1)]  [RED("onHighlightOffAnimation")] public CName OnHighlightOffAnimation { get; set; }
		[Ordinal(2)]  [RED("onHighlightOnAnimation")] public CName OnHighlightOnAnimation { get; set; }
		[Ordinal(3)]  [RED("onSetContentAnimation")] public CName OnSetContentAnimation { get; set; }

		public NetworkMinigameAnimatedElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
