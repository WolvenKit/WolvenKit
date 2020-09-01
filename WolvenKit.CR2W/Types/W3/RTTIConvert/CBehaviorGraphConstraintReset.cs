using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintReset : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("("bone")] 		public CString Bone { get; set;}

		[Ordinal(2)] [RED("("translation")] 		public CBool Translation { get; set;}

		[Ordinal(3)] [RED("("rotation")] 		public CBool Rotation { get; set;}

		[Ordinal(4)] [RED("("scale")] 		public CBool Scale { get; set;}

		[Ordinal(5)] [RED("("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		public CBehaviorGraphConstraintReset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintReset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}