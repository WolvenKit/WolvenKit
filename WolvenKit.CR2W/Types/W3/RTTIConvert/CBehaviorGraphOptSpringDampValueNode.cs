using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphOptSpringDampValueNode : CBehaviorGraphValueBaseNode
	{
		[RED("cachedSmoothTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSmoothTimeNode { get; set;}

		[RED("smoothTime")] 		public CFloat SmoothTime { get; set;}

		[RED("scale")] 		public CFloat Scale { get; set;}

		[RED("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		[RED("maxDiff")] 		public CFloat MaxDiff { get; set;}

		[RED("defaultValue")] 		public CFloat DefaultValue { get; set;}

		[RED("forceInputValueOnActivate")] 		public CBool ForceInputValueOnActivate { get; set;}

		[RED("forceDefaultValueOnActivate")] 		public CBool ForceDefaultValueOnActivate { get; set;}

		public CBehaviorGraphOptSpringDampValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphOptSpringDampValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}