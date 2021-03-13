using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphOptSpringDampValueNode : CBehaviorGraphValueBaseNode
	{
		[Ordinal(1)] [RED("cachedSmoothTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSmoothTimeNode { get; set;}

		[Ordinal(2)] [RED("smoothTime")] 		public CFloat SmoothTime { get; set;}

		[Ordinal(3)] [RED("scale")] 		public CFloat Scale { get; set;}

		[Ordinal(4)] [RED("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		[Ordinal(5)] [RED("maxDiff")] 		public CFloat MaxDiff { get; set;}

		[Ordinal(6)] [RED("defaultValue")] 		public CFloat DefaultValue { get; set;}

		[Ordinal(7)] [RED("forceInputValueOnActivate")] 		public CBool ForceInputValueOnActivate { get; set;}

		[Ordinal(8)] [RED("forceDefaultValueOnActivate")] 		public CBool ForceDefaultValueOnActivate { get; set;}

		public CBehaviorGraphOptSpringDampValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphOptSpringDampValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}