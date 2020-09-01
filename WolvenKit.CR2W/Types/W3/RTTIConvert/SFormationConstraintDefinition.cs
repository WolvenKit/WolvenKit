using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFormationConstraintDefinition : CVariable
	{
		[Ordinal(0)] [RED("("referenceRelativeIndex")] 		public CBool ReferenceRelativeIndex { get; set;}

		[Ordinal(0)] [RED("("referenceSlot")] 		public CInt32 ReferenceSlot { get; set;}

		[Ordinal(0)] [RED("("type")] 		public CEnum<EFormationConstraintType> Type { get; set;}

		[Ordinal(0)] [RED("("value")] 		public Vector2 Value { get; set;}

		[Ordinal(0)] [RED("("strength")] 		public CFloat Strength { get; set;}

		[Ordinal(0)] [RED("("tolerance")] 		public CFloat Tolerance { get; set;}

		public SFormationConstraintDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFormationConstraintDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}