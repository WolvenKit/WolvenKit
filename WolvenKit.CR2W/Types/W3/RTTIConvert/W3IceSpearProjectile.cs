using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3IceSpearProjectile : W3AdvancedProjectile
	{
		[RED("initFxName")] 		public CName InitFxName { get; set;}

		[RED("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[RED("spawnEntityTemplate")] 		public CHandle<CEntityTemplate> SpawnEntityTemplate { get; set;}

		[RED("customDuration")] 		public CFloat CustomDuration { get; set;}

		[RED("onCollisionVictimFxName")] 		public CName OnCollisionVictimFxName { get; set;}

		[RED("immediatelyStopVictimFX")] 		public CBool ImmediatelyStopVictimFX { get; set;}

		public W3IceSpearProjectile(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3IceSpearProjectile(cr2w);

	}
}