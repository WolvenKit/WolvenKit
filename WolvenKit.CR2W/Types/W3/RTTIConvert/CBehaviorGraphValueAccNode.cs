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

		public CBehaviorGraphValueAccNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphValueAccNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}