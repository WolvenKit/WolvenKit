using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskDeathIdleDef : IBehTreeTaskDefinition
	{
		[RED("setAppearanceTo")] 		public CBehTreeValCName SetAppearanceTo { get; set;}

		[RED("changeAppearanceAfter")] 		public CBehTreeValFloat ChangeAppearanceAfter { get; set;}

		[RED("disableCollision")] 		public CBehTreeValBool DisableCollision { get; set;}

		[RED("disableCollisionDelay")] 		public CBehTreeValFloat DisableCollisionDelay { get; set;}

		[RED("disableRagdollAfter")] 		public CBehTreeValFloat DisableRagdollAfter { get; set;}

		public CBehTreeTaskDeathIdleDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeTaskDeathIdleDef(cr2w);

	}
}