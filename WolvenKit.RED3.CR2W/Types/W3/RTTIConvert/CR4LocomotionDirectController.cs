using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4LocomotionDirectController : CObject
	{
		[Ordinal(1)] [RED("agent")] 		public CHandle<CMovingAgentComponent> Agent { get; set;}

		[Ordinal(2)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(3)] [RED("moveRotation")] 		public CFloat MoveRotation { get; set;}

		public CR4LocomotionDirectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4LocomotionDirectController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}