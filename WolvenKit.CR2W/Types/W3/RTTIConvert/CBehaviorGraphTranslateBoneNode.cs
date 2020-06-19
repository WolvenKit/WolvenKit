using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphTranslateBoneNode : CBehaviorGraphBaseNode
	{
		[RED("boneName")] 		public CString BoneName { get; set;}

		[RED("axis")] 		public Vector Axis { get; set;}

		[RED("scale")] 		public CFloat Scale { get; set;}

		[RED("biasValue")] 		public CFloat BiasValue { get; set;}

		[RED("minValue")] 		public CFloat MinValue { get; set;}

		[RED("maxValue")] 		public CFloat MaxValue { get; set;}

		[RED("clampValue")] 		public CBool ClampValue { get; set;}

		[RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		public CBehaviorGraphTranslateBoneNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphTranslateBoneNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}