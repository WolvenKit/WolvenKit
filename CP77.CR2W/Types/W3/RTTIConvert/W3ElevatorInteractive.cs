using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ElevatorInteractive : W3Elevator
	{
		[Ordinal(1)] [RED("initialPosOnTop")] 		public CBool InitialPosOnTop { get; set;}

		[Ordinal(2)] [RED("targetObject")] 		public EntityHandle TargetObject { get; set;}

		[Ordinal(3)] [RED("maxHeight")] 		public CFloat MaxHeight { get; set;}

		[Ordinal(4)] [RED("mechanismEntityHandle")] 		public EntityHandle MechanismEntityHandle { get; set;}

		[Ordinal(5)] [RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[Ordinal(6)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(7)] [RED("explorationComponents", 2,0)] 		public CArray<CHandle<CComponent>> ExplorationComponents { get; set;}

		[Ordinal(8)] [RED("switches", 2,0)] 		public CArray<CHandle<W3ElevatorSwitch>> Switches { get; set;}

		[Ordinal(9)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(10)] [RED("size")] 		public CInt32 Size { get; set;}

		[Ordinal(11)] [RED("elevatorSaveLockInt")] 		public CInt32 ElevatorSaveLockInt { get; set;}

		public W3ElevatorInteractive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ElevatorInteractive(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}