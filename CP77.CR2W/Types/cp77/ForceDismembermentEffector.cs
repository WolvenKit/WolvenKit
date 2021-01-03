using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ForceDismembermentEffector : gameEffector
	{
		[Ordinal(0)]  [RED("bodyPart")] public CEnum<gameDismBodyPart> BodyPart { get; set; }
		[Ordinal(1)]  [RED("dismembermentChance")] public CFloat DismembermentChance { get; set; }
		[Ordinal(2)]  [RED("effectorRecord")] public CHandle<gamedataForceDismembermentEffector_Record> EffectorRecord { get; set; }
		[Ordinal(3)]  [RED("isCritical")] public CBool IsCritical { get; set; }
		[Ordinal(4)]  [RED("shouldKillNPC")] public CBool ShouldKillNPC { get; set; }
		[Ordinal(5)]  [RED("skipDeathAnim")] public CBool SkipDeathAnim { get; set; }
		[Ordinal(6)]  [RED("woundType")] public CEnum<gameDismWoundType> WoundType { get; set; }

		public ForceDismembermentEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
