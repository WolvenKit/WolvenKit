using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFormationConstraintDefinition : CVariable
	{
		[Ordinal(1)] [RED("referenceRelativeIndex")] 		public CBool ReferenceRelativeIndex { get; set;}

		[Ordinal(2)] [RED("referenceSlot")] 		public CInt32 ReferenceSlot { get; set;}

		[Ordinal(3)] [RED("type")] 		public CEnum<EFormationConstraintType> Type { get; set;}

		[Ordinal(4)] [RED("value")] 		public Vector2 Value { get; set;}

		[Ordinal(5)] [RED("strength")] 		public CFloat Strength { get; set;}

		[Ordinal(6)] [RED("tolerance")] 		public CFloat Tolerance { get; set;}

		public SFormationConstraintDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}