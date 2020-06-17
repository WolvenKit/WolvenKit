using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDrunkMutagen : CVariable
	{
		[RED("slot")] 		public CInt32 Slot { get; set;}

		[RED("mutagenName")] 		public CName MutagenName { get; set;}

		[RED("toxicityOffset")] 		public CFloat ToxicityOffset { get; set;}

		[RED("effectType")] 		public EEffectType EffectType { get; set;}

		public SDrunkMutagen(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SDrunkMutagen(cr2w);

	}
}