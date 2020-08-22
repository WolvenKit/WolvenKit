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
		[RED("objectPointHeading")] 		public CFloat ObjectPointHeading { get; set;}

		[RED("objectHeadingSet")] 		public CBool ObjectHeadingSet { get; set;}

		[RED("stopRequested")] 		public CBool StopRequested { get; set;}

		[RED("objectEntity")] 		public CHandle<CEntity> ObjectEntity { get; set;}

		[RED("switchOn")] 		public CBool SwitchOn { get; set;}

		[RED("switchAnimationType")] 		public CEnum<PhysicalSwitchAnimationType> SwitchAnimationType { get; set;}

		public W3PlayerWitcherStateApproachInteractionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerWitcherStateApproachInteractionState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}