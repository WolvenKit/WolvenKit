using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3StoneProjectile : W3AdvancedProjectile
	{
		[Ordinal(1)] [RED("initFxName")] 		public CName InitFxName { get; set;}

		[Ordinal(2)] [RED("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[Ordinal(3)] [RED("stoneTemplate")] 		public CHandle<CEntityTemplate> StoneTemplate { get; set;}

		[Ordinal(4)] [RED("action")] 		public CHandle<W3DamageAction> Action { get; set;}

		[Ordinal(5)] [RED("comp")] 		public CHandle<CMeshComponent> Comp { get; set;}

		public W3StoneProjectile(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3StoneProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}