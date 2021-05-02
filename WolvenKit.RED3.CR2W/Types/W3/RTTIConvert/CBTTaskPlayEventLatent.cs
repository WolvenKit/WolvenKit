using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayEventLatent : IBehTreeTask
	{
		[Ordinal(1)] [RED("nodeDeactivationName")] 		public CName NodeDeactivationName { get; set;}

		[Ordinal(2)] [RED("playEventName")] 		public CName PlayEventName { get; set;}

		[Ordinal(3)] [RED("eventIsForced")] 		public CBool EventIsForced { get; set;}

		[Ordinal(4)] [RED("setVariable")] 		public CBool SetVariable { get; set;}

		[Ordinal(5)] [RED("variableName")] 		public CName VariableName { get; set;}

		[Ordinal(6)] [RED("variableValue")] 		public CFloat VariableValue { get; set;}

		public CBTTaskPlayEventLatent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayEventLatent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}