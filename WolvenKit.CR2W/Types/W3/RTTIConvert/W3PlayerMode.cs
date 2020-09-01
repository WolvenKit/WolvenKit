using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerMode : CObject
	{
		[Ordinal(0)] [RED("("player")] 		public CHandle<CPlayer> Player { get; set;}

		[Ordinal(0)] [RED("("currentMode")] 		public CEnum<EPlayerMode> CurrentMode { get; set;}

		[Ordinal(0)] [RED("("safeMode")] 		public CBool SafeMode { get; set;}

		[Ordinal(0)] [RED("("combatMode")] 		public CBool CombatMode { get; set;}

		[Ordinal(0)] [RED("("combatDataComponent")] 		public CHandle<CCombatDataComponent> CombatDataComponent { get; set;}

		[Ordinal(0)] [RED("("combatModeTimer")] 		public CFloat CombatModeTimer { get; set;}

		[Ordinal(0)] [RED("("combatModeDelay")] 		public CFloat CombatModeDelay { get; set;}

		[Ordinal(0)] [RED("("forceCombatMode")] 		public CInt32 ForceCombatMode { get; set;}

		[Ordinal(0)] [RED("("combatModeBlockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> CombatModeBlockedActions { get; set;}

		[Ordinal(0)] [RED("("safeModeBlockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> SafeModeBlockedActions { get; set;}

		public W3PlayerMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerMode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}