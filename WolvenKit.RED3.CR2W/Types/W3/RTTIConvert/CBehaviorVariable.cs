using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorVariable : CBaseBehaviorVariable
	{
		[Ordinal(1)] [RED("value")] 		public CFloat Value { get; set;}

		[Ordinal(2)] [RED("defaultValue")] 		public CFloat DefaultValue { get; set;}

		[Ordinal(3)] [RED("minValue")] 		public CFloat MinValue { get; set;}

		[Ordinal(4)] [RED("maxValue")] 		public CFloat MaxValue { get; set;}

		[Ordinal(5)] [RED("isModifiableByEffect")] 		public CBool IsModifiableByEffect { get; set;}

		[Ordinal(6)] [RED("shouldBeSyncedBetweenGraphs")] 		public CBool ShouldBeSyncedBetweenGraphs { get; set;}

		public CBehaviorVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorVariable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}