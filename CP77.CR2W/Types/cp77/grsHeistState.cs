using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class grsHeistState : CVariable
	{
		[Ordinal(0)] [RED("time")] public netTime Time { get; set; }
		[Ordinal(1)] [RED("status")] public CEnum<grsHeistStatus> Status { get; set; }
		[Ordinal(2)] [RED("playersInfo", 7)] public CStatic<grsHeistPlayerGameInfo> PlayersInfo { get; set; }

		public grsHeistState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
