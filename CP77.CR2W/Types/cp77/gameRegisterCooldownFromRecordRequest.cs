using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameRegisterCooldownFromRecordRequest : CVariable
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(1)] [RED("ownerItemId")] public gameItemID OwnerItemId { get; set; }
		[Ordinal(2)] [RED("ownerRecord")] public TweakDBID OwnerRecord { get; set; }
		[Ordinal(3)] [RED("cooldownRecord")] public CHandle<gamedataCooldown_Record> CooldownRecord { get; set; }

		public gameRegisterCooldownFromRecordRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
