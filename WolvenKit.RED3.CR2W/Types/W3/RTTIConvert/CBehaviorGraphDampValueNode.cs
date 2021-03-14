using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphDampValueNode : CBehaviorGraphValueBaseNode
	{
		[Ordinal(1)] [RED("increaseSpeed")] 		public CFloat IncreaseSpeed { get; set;}

		[Ordinal(2)] [RED("decreaseSpeed")] 		public CFloat DecreaseSpeed { get; set;}

		[Ordinal(3)] [RED("absolute")] 		public CBool Absolute { get; set;}

		[Ordinal(4)] [RED("startFromDefault")] 		public CBool StartFromDefault { get; set;}

		[Ordinal(5)] [RED("defaultValue")] 		public CFloat DefaultValue { get; set;}

		[Ordinal(6)] [RED("cachedDefaultValNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDefaultValNode { get; set;}

		[Ordinal(7)] [RED("cachedIncSpeedNode")] 		public CPtr<CBehaviorGraphValueNode> CachedIncSpeedNode { get; set;}

		[Ordinal(8)] [RED("cachedDecSpeedNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDecSpeedNode { get; set;}

		public CBehaviorGraphDampValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphDampValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}