using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphValueAccNode : CBehaviorGraphValueBaseNode
	{
		[RED("resetOnActivation")] 		public CBool ResetOnActivation { get; set;}

		[RED("initValue")] 		public CFloat InitValue { get; set;}

		[RED("wrapValue")] 		public CBool WrapValue { get; set;}

		[RED("wrapValueThrMax")] 		public CFloat WrapValueThrMax { get; set;}

		[RED("wrapValueThrMin")] 		public CFloat WrapValueThrMin { get; set;}

		public CBehaviorGraphValueAccNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphValueAccNode(cr2w);

	}
}