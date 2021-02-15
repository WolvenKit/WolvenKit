using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedamageServerHitData : IScriptable
	{
		[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(1)] [RED("damageInfos")] public CArray<gameuiDamageInfo> DamageInfos { get; set; }
		[Ordinal(2)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }

		public gamedamageServerHitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
