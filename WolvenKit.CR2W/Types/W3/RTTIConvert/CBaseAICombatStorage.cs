using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBaseAICombatStorage : IScriptable
	{
		[RED("isAttacking")] 		public CBool IsAttacking { get; set;}

		[RED("isCharging")] 		public CBool IsCharging { get; set;}

		[RED("isTaunting")] 		public CBool IsTaunting { get; set;}

		[RED("isShooting")] 		public CBool IsShooting { get; set;}

		[RED("isAiming")] 		public CBool IsAiming { get; set;}

		[RED("isInImportantAnim")] 		public CBool IsInImportantAnim { get; set;}

		[RED("preCombatWarning")] 		public CBool PreCombatWarning { get; set;}

		[RED("atackTimeStamp")] 		public CFloat AtackTimeStamp { get; set;}

		[RED("tauntTimeStamp")] 		public CFloat TauntTimeStamp { get; set;}

		[RED("CSArray", 2,0)] 		public CArray<CriticalStateStruct> CSArray { get; set;}

		public CBaseAICombatStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBaseAICombatStorage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}