using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RemotePlayerMappinController : gameuiInteractionMappinController
	{
		[Ordinal(0)]  [RED("mappin")] public wCHandle<gamemappinsRemotePlayerMappin> Mappin { get; set; }
		[Ordinal(1)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }

		public RemotePlayerMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
