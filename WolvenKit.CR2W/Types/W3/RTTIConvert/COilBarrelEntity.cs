using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class COilBarrelEntity : CGameplayEntity
	{
		[RED("fx_onInteraction")] 		public CName Fx_onInteraction { get; set;}

		[RED("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[RED("explodeAfter")] 		public CFloat ExplodeAfter { get; set;}

		[RED("destroyEntAfter")] 		public CFloat DestroyEntAfter { get; set;}

		[RED("randomizeTime")] 		public CBool RandomizeTime { get; set;}

		[RED("onFireDamagePerSec")] 		public CFloat OnFireDamagePerSec { get; set;}

		public COilBarrelEntity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new COilBarrelEntity(cr2w);

	}
}