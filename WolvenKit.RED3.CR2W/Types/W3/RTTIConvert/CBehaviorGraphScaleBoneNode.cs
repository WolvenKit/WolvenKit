using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphScaleBoneNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(2)] [RED("scale")] 		public Vector Scale { get; set;}

		[Ordinal(3)] [RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedControlVariableNode { get; set;}

		public CBehaviorGraphScaleBoneNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphScaleBoneNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}