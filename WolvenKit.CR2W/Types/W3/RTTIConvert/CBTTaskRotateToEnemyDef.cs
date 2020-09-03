using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskRotateToEnemyDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("toleranceAngle")] 		public CFloat ToleranceAngle { get; set;}

		[Ordinal(2)] [RED("rotateOnRotateEvent")] 		public CBool RotateOnRotateEvent { get; set;}

		public CBTTaskRotateToEnemyDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskRotateToEnemyDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}