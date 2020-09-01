using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DragonsDream : W3Petard
	{
		[Ordinal(1)] [RED("gasEntityTemplate")] 		public CHandle<CEntityTemplate> GasEntityTemplate { get; set;}

		[Ordinal(2)] [RED("gasEntity")] 		public CHandle<W3ToxicCloud> GasEntity { get; set;}

		[Ordinal(3)] [RED("burningChance")] 		public CFloat BurningChance { get; set;}

		public W3DragonsDream(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DragonsDream(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}