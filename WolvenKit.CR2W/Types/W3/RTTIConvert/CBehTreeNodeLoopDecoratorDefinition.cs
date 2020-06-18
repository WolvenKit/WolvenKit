using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeLoopDecoratorDefinition : IBehTreeNodeDecoratorDefinition
	{
		[RED("onCompleted")] 		public CEnum<EBTLoopMode> OnCompleted { get; set;}

		[RED("onFailed")] 		public CEnum<EBTLoopMode> OnFailed { get; set;}

		[RED("maxIterations")] 		public CBehTreeValInt MaxIterations { get; set;}

		[RED("reactivationDelay")] 		public CFloat ReactivationDelay { get; set;}

		public CBehTreeNodeLoopDecoratorDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeLoopDecoratorDefinition(cr2w);

	}
}