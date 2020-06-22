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
		[RED("player")] 		public CHandle<CPlayer> Player { get; set;}

		[RED("currentMode")] 		public CEnum<EPlayerMode> CurrentMode { get; set;}

		[RED("safeMode")] 		public CBool SafeMode { get; set;}

		[RED("combatMode")] 		public CBool CombatMode { get; set;}

		[RED("combatDataComponent")] 		public CHandle<CCombatDataComponent> CombatDataComponent { get; set;}

		[RED("combatModeTimer")] 		public CFloat CombatModeTimer { get; set;}

		[RED("combatModeDelay")] 		public CFloat CombatModeDelay { get; set;}

		[RED("forceCombatMode")] 		public CInt32 ForceCombatMode { get; set;}

		[RED("combatModeBlockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> CombatModeBlockedActions { get; set;}

		[RED("safeModeBlockedActions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> SafeModeBlockedActions { get; set;}

		public W3PlayerMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerMode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}