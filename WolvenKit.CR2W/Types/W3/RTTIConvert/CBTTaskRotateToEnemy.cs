using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskRotateToEnemy : IBehTreeTask
	{
		[Ordinal(1)] [RED("toleranceAngle")] 		public CFloat ToleranceAngle { get; set;}

		[Ordinal(2)] [RED("isMoving")] 		public CBool IsMoving { get; set;}

		[Ordinal(3)] [RED("rotateOnRotateEvent")] 		public CBool RotateOnRotateEvent { get; set;}

		public CBTTaskRotateToEnemy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskRotateToEnemy(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}