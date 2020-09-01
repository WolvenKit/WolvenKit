using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class COilBarrelEntity : CGameplayEntity
	{
		[Ordinal(0)] [RED("fx_onInteraction")] 		public CName Fx_onInteraction { get; set;}

		[Ordinal(0)] [RED("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[Ordinal(0)] [RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[Ordinal(0)] [RED("explodeAfter")] 		public CFloat ExplodeAfter { get; set;}

		[Ordinal(0)] [RED("destroyEntAfter")] 		public CFloat DestroyEntAfter { get; set;}

		[Ordinal(0)] [RED("randomizeTime")] 		public CBool RandomizeTime { get; set;}

		[Ordinal(0)] [RED("onFireDamagePerSec")] 		public CFloat OnFireDamagePerSec { get; set;}

		[Ordinal(0)] [RED("isSetOnFire")] 		public CBool IsSetOnFire { get; set;}

		[Ordinal(0)] [RED("isExploding")] 		public CBool IsExploding { get; set;}

		[Ordinal(0)] [RED("onFireDamageArea")] 		public CHandle<CTriggerAreaComponent> OnFireDamageArea { get; set;}

		[Ordinal(0)] [RED("entitiesInOnFireArea", 2,0)] 		public CArray<CHandle<CGameplayEntity>> EntitiesInOnFireArea { get; set;}

		public COilBarrelEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new COilBarrelEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}