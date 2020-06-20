using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIShootActionTree : IAICustomActionTree
	{
		[RED("targetTag")] 		public CName TargetTag { get; set;}

		[RED("multipleTargetsTags")] 		public CHandle<W3BehTreeValNameArray> MultipleTargetsTags { get; set;}

		[RED("numberOfActions")] 		public CInt32 NumberOfActions { get; set;}

		[RED("setProjectileOnFire")] 		public CBool SetProjectileOnFire { get; set;}

		[RED("afterActionIdleDuration")] 		public CFloat AfterActionIdleDuration { get; set;}

		[RED("afterActionIdleDurationChance")] 		public CFloat AfterActionIdleDurationChance { get; set;}

		[RED("useRayCastBeforeShooting")] 		public CBool UseRayCastBeforeShooting { get; set;}

		public CAIShootActionTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIShootActionTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}