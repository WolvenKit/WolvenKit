using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayEventLatent : IBehTreeTask
	{
		[Ordinal(0)] [RED("("nodeDeactivationName")] 		public CName NodeDeactivationName { get; set;}

		[Ordinal(0)] [RED("("playEventName")] 		public CName PlayEventName { get; set;}

		[Ordinal(0)] [RED("("eventIsForced")] 		public CBool EventIsForced { get; set;}

		[Ordinal(0)] [RED("("setVariable")] 		public CBool SetVariable { get; set;}

		[Ordinal(0)] [RED("("variableName")] 		public CName VariableName { get; set;}

		[Ordinal(0)] [RED("("variableValue")] 		public CFloat VariableValue { get; set;}

		public CBTTaskPlayEventLatent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayEventLatent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}