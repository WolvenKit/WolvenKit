using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBaseAICombatStorage : IScriptable
	{
		[Ordinal(1)] [RED("isAttacking")] 		public CBool IsAttacking { get; set;}

		[Ordinal(2)] [RED("isCharging")] 		public CBool IsCharging { get; set;}

		[Ordinal(3)] [RED("isTaunting")] 		public CBool IsTaunting { get; set;}

		[Ordinal(4)] [RED("isShooting")] 		public CBool IsShooting { get; set;}

		[Ordinal(5)] [RED("isAiming")] 		public CBool IsAiming { get; set;}

		[Ordinal(6)] [RED("isInImportantAnim")] 		public CBool IsInImportantAnim { get; set;}

		[Ordinal(7)] [RED("preCombatWarning")] 		public CBool PreCombatWarning { get; set;}

		[Ordinal(8)] [RED("atackTimeStamp")] 		public CFloat AtackTimeStamp { get; set;}

		[Ordinal(9)] [RED("tauntTimeStamp")] 		public CFloat TauntTimeStamp { get; set;}

		[Ordinal(10)] [RED("CSArray", 2,0)] 		public CArray<CriticalStateStruct> CSArray { get; set;}

		public CBaseAICombatStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBaseAICombatStorage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}