using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class grsHeistState : CVariable
	{
		[Ordinal(0)]  [RED("playersInfo")] public CStatic<7,grsHeistPlayerGameInfo> PlayersInfo { get; set; }
		[Ordinal(1)]  [RED("status")] public CEnum<grsHeistStatus> Status { get; set; }
		[Ordinal(2)]  [RED("time")] public netTime Time { get; set; }

		public grsHeistState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
