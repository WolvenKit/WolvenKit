using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAICombatModeActionDecorator : IActionDecorator
	{
		[RED("drawWeaponOnStart")] 		public CBool DrawWeaponOnStart { get; set;}

		[RED("LeftItemType")] 		public CName LeftItemType { get; set;}

		[RED("RightItemType")] 		public CName RightItemType { get; set;}

		[RED("changeBehaviorGraphOnStart")] 		public CBool ChangeBehaviorGraphOnStart { get; set;}

		[RED("behGraph")] 		public CEnum<EBehaviorGraph> BehGraph { get; set;}

		[RED("changeBahviorGraphToExplorationOnDeacitvate")] 		public CBool ChangeBahviorGraphToExplorationOnDeacitvate { get; set;}

		[RED("forceCombatModeOnPLAYER")] 		public CBool ForceCombatModeOnPLAYER { get; set;}

		public CAICombatModeActionDecorator(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAICombatModeActionDecorator(cr2w);

	}
}