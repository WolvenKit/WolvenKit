using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskIdle : IBehTreeTask
	{
		[Ordinal(0)] [RED("toleranceAngle")] 		public CFloat ToleranceAngle { get; set;}

		[Ordinal(0)] [RED("checkRotation")] 		public CBool CheckRotation { get; set;}

		[Ordinal(0)] [RED("isMoving")] 		public CBool IsMoving { get; set;}

		public CBTTaskIdle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskIdle(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}