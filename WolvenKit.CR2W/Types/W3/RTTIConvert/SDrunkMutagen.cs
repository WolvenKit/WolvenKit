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

		[RED("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		public SDrunkMutagen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDrunkMutagen(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}