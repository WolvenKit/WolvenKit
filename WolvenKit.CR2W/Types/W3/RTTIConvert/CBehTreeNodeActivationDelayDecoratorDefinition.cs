using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeActivationDelayDecoratorDefinition : IBehTreeNodeDecoratorDefinition
	{
		[RED("delayOnSuccess")] 		public CBehTreeValFloat DelayOnSuccess { get; set;}

		[RED("delayOnFailure")] 		public CBehTreeValFloat DelayOnFailure { get; set;}

		[RED("delayOnInterruption")] 		public CBehTreeValFloat DelayOnInterruption { get; set;}

		public CBehTreeNodeActivationDelayDecoratorDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeActivationDelayDecoratorDefinition(cr2w);

	}
}