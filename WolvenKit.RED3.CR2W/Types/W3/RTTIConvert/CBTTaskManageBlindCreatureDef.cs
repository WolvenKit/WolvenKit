using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageBlindCreatureDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(2)] [RED("forgetTargetIfNPCSpeedLowerThan")] 		public CFloat ForgetTargetIfNPCSpeedLowerThan { get; set;}

		[Ordinal(3)] [RED("remberTargetIfCloserThan")] 		public CFloat RemberTargetIfCloserThan { get; set;}

		[Ordinal(4)] [RED("ignoreNoiseLowerThanWhenSprinting")] 		public CFloat IgnoreNoiseLowerThanWhenSprinting { get; set;}

		[Ordinal(5)] [RED("prioritizePlayerAsTarget")] 		public CBehTreeValBool PrioritizePlayerAsTarget { get; set;}

		public CBTTaskManageBlindCreatureDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskManageBlindCreatureDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}