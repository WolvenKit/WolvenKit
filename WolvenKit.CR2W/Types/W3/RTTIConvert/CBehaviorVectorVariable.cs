using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorVectorVariable : CBaseBehaviorVariable
	{
		[RED("value")] 		public Vector Value { get; set;}

		[RED("defaultValue")] 		public Vector DefaultValue { get; set;}

		[RED("minValue")] 		public Vector MinValue { get; set;}

		[RED("maxValue")] 		public Vector MaxValue { get; set;}

		[RED("space")] 		public CEnum<EVariableSpace> Space { get; set;}

		[RED("type")] 		public CEnum<EVectorVariableType> Type { get; set;}

		[RED("shouldBeSyncedBetweenGraphs")] 		public CBool ShouldBeSyncedBetweenGraphs { get; set;}

		public CBehaviorVectorVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorVectorVariable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}