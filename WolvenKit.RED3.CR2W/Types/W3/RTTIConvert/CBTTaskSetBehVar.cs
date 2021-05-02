using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetBehVar : IBehTreeTask
	{
		[Ordinal(1)] [RED("behVarName")] 		public CName BehVarName { get; set;}

		[Ordinal(2)] [RED("behVarValue")] 		public CFloat BehVarValue { get; set;}

		[Ordinal(3)] [RED("inAllBehGraphs")] 		public CBool InAllBehGraphs { get; set;}

		[Ordinal(4)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(5)] [RED("onSuccess")] 		public CBool OnSuccess { get; set;}

		public CBTTaskSetBehVar(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}