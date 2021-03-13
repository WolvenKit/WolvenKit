using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4LocomotionSwimToStop : CR4LocomotionDirectControllerScript
	{
		[Ordinal(1)] [RED("player")] 		public CHandle<CR4Player> Player { get; set;}

		[Ordinal(2)] [RED("targetPoint")] 		public Vector TargetPoint { get; set;}

		[Ordinal(3)] [RED("closeEnough")] 		public CBool CloseEnough { get; set;}

		public CR4LocomotionSwimToStop(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4LocomotionSwimToStop(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}