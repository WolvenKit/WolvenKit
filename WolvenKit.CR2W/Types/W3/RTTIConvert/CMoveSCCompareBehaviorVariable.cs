using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSCCompareBehaviorVariable : IMoveSteeringCondition
	{
		[Ordinal(0)] [RED("variableName")] 		public CName VariableName { get; set;}

		[Ordinal(0)] [RED("referenceVal")] 		public CFloat ReferenceVal { get; set;}

		[Ordinal(0)] [RED("comparison")] 		public CEnum<ECompareFunc> Comparison { get; set;}

		public CMoveSCCompareBehaviorVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSCCompareBehaviorVariable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}