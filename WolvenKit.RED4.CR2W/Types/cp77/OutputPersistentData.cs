using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutputPersistentData : CVariable
	{
		[Ordinal(0)] [RED("currentSecurityState")] public CEnum<ESecuritySystemState> CurrentSecurityState { get; set; }
		[Ordinal(1)] [RED("breachOrigin")] public CEnum<EBreachOrigin> BreachOrigin { get; set; }
		[Ordinal(2)] [RED("securityStateChanged")] public CBool SecurityStateChanged { get; set; }
		[Ordinal(3)] [RED("lastKnownPosition")] public Vector4 LastKnownPosition { get; set; }
		[Ordinal(4)] [RED("type")] public CEnum<ESecurityNotificationType> Type { get; set; }
		[Ordinal(5)] [RED("areaType")] public CEnum<ESecurityAreaType> AreaType { get; set; }
		[Ordinal(6)] [RED("objectOfInterest")] public entEntityID ObjectOfInterest { get; set; }
		[Ordinal(7)] [RED("whoBreached")] public entEntityID WhoBreached { get; set; }
		[Ordinal(8)] [RED("reporter")] public gamePersistentID Reporter { get; set; }
		[Ordinal(9)] [RED("id")] public CInt32 Id { get; set; }

		public OutputPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
