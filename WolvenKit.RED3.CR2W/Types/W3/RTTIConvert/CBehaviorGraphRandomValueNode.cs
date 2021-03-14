using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRandomValueNode : CBehaviorGraphValueNode
	{
		[Ordinal(1)] [RED("value")] 		public CFloat Value { get; set;}

		[Ordinal(2)] [RED("randDefaultValue")] 		public CBool RandDefaultValue { get; set;}

		[Ordinal(3)] [RED("rand")] 		public CBool Rand { get; set;}

		[Ordinal(4)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(5)] [RED("min")] 		public CFloat Min { get; set;}

		[Ordinal(6)] [RED("max")] 		public CFloat Max { get; set;}

		public CBehaviorGraphRandomValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphRandomValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}