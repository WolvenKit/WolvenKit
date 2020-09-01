using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageBlindCreatureDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("("forgetTargetIfNPCSpeedLowerThan")] 		public CFloat ForgetTargetIfNPCSpeedLowerThan { get; set;}

		[Ordinal(0)] [RED("("remberTargetIfCloserThan")] 		public CFloat RemberTargetIfCloserThan { get; set;}

		[Ordinal(0)] [RED("("ignoreNoiseLowerThanWhenSprinting")] 		public CFloat IgnoreNoiseLowerThanWhenSprinting { get; set;}

		[Ordinal(0)] [RED("("prioritizePlayerAsTarget")] 		public CBehTreeValBool PrioritizePlayerAsTarget { get; set;}

		public CBTTaskManageBlindCreatureDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskManageBlindCreatureDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}