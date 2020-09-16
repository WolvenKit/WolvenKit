using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAICombatModeActionDecorator : IActionDecorator
	{
		[Ordinal(1)] [RED("drawWeaponOnStart")] 		public CBool DrawWeaponOnStart { get; set;}

		[Ordinal(2)] [RED("LeftItemType")] 		public CName LeftItemType { get; set;}

		[Ordinal(3)] [RED("RightItemType")] 		public CName RightItemType { get; set;}

		[Ordinal(4)] [RED("changeBehaviorGraphOnStart")] 		public CBool ChangeBehaviorGraphOnStart { get; set;}

		[Ordinal(5)] [RED("behGraph")] 		public CEnum<EBehaviorGraph> BehGraph { get; set;}

		[Ordinal(6)] [RED("changeBahviorGraphToExplorationOnDeacitvate")] 		public CBool ChangeBahviorGraphToExplorationOnDeacitvate { get; set;}

		[Ordinal(7)] [RED("forceCombatModeOnPLAYER")] 		public CBool ForceCombatModeOnPLAYER { get; set;}

		public CAICombatModeActionDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAICombatModeActionDecorator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}