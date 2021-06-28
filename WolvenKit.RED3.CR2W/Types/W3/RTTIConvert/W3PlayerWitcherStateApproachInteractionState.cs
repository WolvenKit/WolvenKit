using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerWitcherStateApproachInteractionState : CR4PlayerStateExtendedMovable
	{
		[Ordinal(1)] [RED("objectPointHeading")] 		public CFloat ObjectPointHeading { get; set;}

		[Ordinal(2)] [RED("objectHeadingSet")] 		public CBool ObjectHeadingSet { get; set;}

		[Ordinal(3)] [RED("stopRequested")] 		public CBool StopRequested { get; set;}

		[Ordinal(4)] [RED("objectEntity")] 		public CHandle<CEntity> ObjectEntity { get; set;}

		[Ordinal(5)] [RED("switchOn")] 		public CBool SwitchOn { get; set;}

		[Ordinal(6)] [RED("switchAnimationType")] 		public CEnum<PhysicalSwitchAnimationType> SwitchAnimationType { get; set;}

		public W3PlayerWitcherStateApproachInteractionState(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}