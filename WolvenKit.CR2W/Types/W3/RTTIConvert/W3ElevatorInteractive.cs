using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ElevatorInteractive : W3Elevator
	{
		[RED("initialPosOnTop")] 		public CBool InitialPosOnTop { get; set;}

		[RED("targetObject")] 		public EntityHandle TargetObject { get; set;}

		[RED("maxHeight")] 		public CFloat MaxHeight { get; set;}

		[RED("mechanismEntityHandle")] 		public EntityHandle MechanismEntityHandle { get; set;}

		public W3ElevatorInteractive(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ElevatorInteractive(cr2w);

	}
}