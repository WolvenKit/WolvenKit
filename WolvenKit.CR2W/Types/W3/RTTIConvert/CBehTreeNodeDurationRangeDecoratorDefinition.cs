using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeDurationRangeDecoratorDefinition : IBehTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("durationMin")] 		public CBehTreeValFloat DurationMin { get; set;}

		[Ordinal(2)] [RED("durationMax")] 		public CBehTreeValFloat DurationMax { get; set;}

		[Ordinal(3)] [RED("endWithFailure")] 		public CBool EndWithFailure { get; set;}

		public CBehTreeNodeDurationRangeDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeDurationRangeDecoratorDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}