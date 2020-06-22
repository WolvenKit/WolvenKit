using System.IO;
using System.Runtime.Serialization;
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

		[RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("explorationComponents", 2,0)] 		public CArray<CHandle<CComponent>> ExplorationComponents { get; set;}

		[RED("switches", 2,0)] 		public CArray<CHandle<W3ElevatorSwitch>> Switches { get; set;}

		[RED("i")] 		public CInt32 I { get; set;}

		[RED("size")] 		public CInt32 Size { get; set;}

		[RED("elevatorSaveLockInt")] 		public CInt32 ElevatorSaveLockInt { get; set;}

		public W3ElevatorInteractive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ElevatorInteractive(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}