using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemotePlayerMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] [RED("mappin")] public wCHandle<gamemappinsRemotePlayerMappin> Mappin { get; set; }
		[Ordinal(12)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }

		public RemotePlayerMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
