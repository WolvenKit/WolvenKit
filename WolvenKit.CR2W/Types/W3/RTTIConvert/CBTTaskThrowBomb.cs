using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskThrowBomb : CBTTaskAttack
	{
		[Ordinal(0)] [RED("("thrownEntity")] 		public CHandle<W3Petard> ThrownEntity { get; set;}

		[Ordinal(0)] [RED("("inventory")] 		public CHandle<CInventoryComponent> Inventory { get; set;}

		[Ordinal(0)] [RED("("bombs", 2,0)] 		public CArray<SItemUniqueId> Bombs { get; set;}

		[Ordinal(0)] [RED("("cachedTargetPos")] 		public Vector CachedTargetPos { get; set;}

		[Ordinal(0)] [RED("("dontUseDiwmeritium")] 		public CBool DontUseDiwmeritium { get; set;}

		[Ordinal(0)] [RED("("activationChance")] 		public CFloat ActivationChance { get; set;}

		public CBTTaskThrowBomb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskThrowBomb(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}