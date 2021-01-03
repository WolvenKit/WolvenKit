using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractionMappinController : gameuiInteractionMappinController
	{
		[Ordinal(0)]  [RED("isConnected")] public CBool IsConnected { get; set; }
		[Ordinal(1)]  [RED("mappin")] public wCHandle<gamemappinsInteractionMappin> Mappin { get; set; }
		[Ordinal(2)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }

		public InteractionMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
