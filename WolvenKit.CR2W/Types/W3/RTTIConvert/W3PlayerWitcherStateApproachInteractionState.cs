using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerWitcherStateApproachInteractionState : CR4PlayerStateExtendedMovable
	{
		[Ordinal(0)] [RED("("objectPointHeading")] 		public CFloat ObjectPointHeading { get; set;}

		[Ordinal(0)] [RED("("objectHeadingSet")] 		public CBool ObjectHeadingSet { get; set;}

		[Ordinal(0)] [RED("("stopRequested")] 		public CBool StopRequested { get; set;}

		[Ordinal(0)] [RED("("objectEntity")] 		public CHandle<CEntity> ObjectEntity { get; set;}

		[Ordinal(0)] [RED("("switchOn")] 		public CBool SwitchOn { get; set;}

		[Ordinal(0)] [RED("("switchAnimationType")] 		public CEnum<PhysicalSwitchAnimationType> SwitchAnimationType { get; set;}

		public W3PlayerWitcherStateApproachInteractionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerWitcherStateApproachInteractionState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}