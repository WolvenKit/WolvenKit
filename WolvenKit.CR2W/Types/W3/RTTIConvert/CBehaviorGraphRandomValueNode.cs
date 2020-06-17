using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRandomValueNode : CBehaviorGraphValueNode
	{
		[RED("value")] 		public CFloat Value { get; set;}

		[RED("randDefaultValue")] 		public CBool RandDefaultValue { get; set;}

		[RED("rand")] 		public CBool Rand { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("min")] 		public CFloat Min { get; set;}

		[RED("max")] 		public CFloat Max { get; set;}

		public CBehaviorGraphRandomValueNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphRandomValueNode(cr2w);

	}
}