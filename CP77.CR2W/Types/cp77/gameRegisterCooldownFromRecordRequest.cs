using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameRegisterCooldownFromRecordRequest : CVariable
	{
		[Ordinal(0)]  [RED("cooldownRecord")] public CHandle<gamedataCooldown_Record> CooldownRecord { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(2)]  [RED("ownerItemId")] public gameItemID OwnerItemId { get; set; }
		[Ordinal(3)]  [RED("ownerRecord")] public TweakDBID OwnerRecord { get; set; }

		public gameRegisterCooldownFromRecordRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
