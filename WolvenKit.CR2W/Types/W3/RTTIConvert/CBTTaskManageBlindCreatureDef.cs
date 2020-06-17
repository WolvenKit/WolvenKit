using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageBlindCreatureDef : IBehTreeTaskDefinition
	{
		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("forgetTargetIfNPCSpeedLowerThan")] 		public CFloat ForgetTargetIfNPCSpeedLowerThan { get; set;}

		[RED("remberTargetIfCloserThan")] 		public CFloat RemberTargetIfCloserThan { get; set;}

		[RED("ignoreNoiseLowerThanWhenSprinting")] 		public CFloat IgnoreNoiseLowerThanWhenSprinting { get; set;}

		[RED("prioritizePlayerAsTarget")] 		public CBehTreeValBool PrioritizePlayerAsTarget { get; set;}

		public CBTTaskManageBlindCreatureDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskManageBlindCreatureDef(cr2w);

	}
}