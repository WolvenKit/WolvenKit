using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphTranslateBoneNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(2)] [RED("axis")] 		public Vector Axis { get; set;}

		[Ordinal(3)] [RED("scale")] 		public CFloat Scale { get; set;}

		[Ordinal(4)] [RED("biasValue")] 		public CFloat BiasValue { get; set;}

		[Ordinal(5)] [RED("minValue")] 		public CFloat MinValue { get; set;}

		[Ordinal(6)] [RED("maxValue")] 		public CFloat MaxValue { get; set;}

		[Ordinal(7)] [RED("clampValue")] 		public CBool ClampValue { get; set;}

		[Ordinal(8)] [RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		public CBehaviorGraphTranslateBoneNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphTranslateBoneNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}