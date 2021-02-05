using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class grsHeistState : CVariable
	{
		[Ordinal(0)]  [RED("time")] public netTime Time { get; set; }
		[Ordinal(1)]  [RED("status")] public CEnum<grsHeistStatus> Status { get; set; }
		[Ordinal(2)]  [RED("playersInfo", lignas(16) StaticArray<grsHeistPlayerGameInf, 7)] public alignas(16) StaticArray<grsHeistPlayerGameInfo> PlayersInfo { get; set; }

		public grsHeistState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
