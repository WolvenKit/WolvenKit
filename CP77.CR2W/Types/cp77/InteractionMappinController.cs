using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractionMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] [RED("mappin")] public wCHandle<gamemappinsInteractionMappin> Mappin { get; set; }
		[Ordinal(12)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(13)] [RED("isConnected")] public CBool IsConnected { get; set; }

		public InteractionMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
