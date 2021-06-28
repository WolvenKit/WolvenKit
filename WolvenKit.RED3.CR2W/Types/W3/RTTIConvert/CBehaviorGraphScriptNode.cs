using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphScriptNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("script")] 		public CPtr<IBehaviorScript> Script { get; set;}

		[Ordinal(2)] [RED("cachedFloatNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphValueNode>> CachedFloatNodes { get; set;}

		[Ordinal(3)] [RED("cachedVectorNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphVectorValueNode>> CachedVectorNodes { get; set;}

		public CBehaviorGraphScriptNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}