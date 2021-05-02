using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorVectorVariable : CBaseBehaviorVariable
	{
		[Ordinal(1)] [RED("value")] 		public Vector Value { get; set;}

		[Ordinal(2)] [RED("defaultValue")] 		public Vector DefaultValue { get; set;}

		[Ordinal(3)] [RED("minValue")] 		public Vector MinValue { get; set;}

		[Ordinal(4)] [RED("maxValue")] 		public Vector MaxValue { get; set;}

		[Ordinal(5)] [RED("space")] 		public CEnum<EVariableSpace> Space { get; set;}

		[Ordinal(6)] [RED("type")] 		public CEnum<EVectorVariableType> Type { get; set;}

		[Ordinal(7)] [RED("shouldBeSyncedBetweenGraphs")] 		public CBool ShouldBeSyncedBetweenGraphs { get; set;}

		public CBehaviorVectorVariable(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorVectorVariable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}