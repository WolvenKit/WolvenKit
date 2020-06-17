using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ArachasEggCustom : W3MonsterClue
	{
		[RED("morphTimeIgni")] 		public CFloat MorphTimeIgni { get; set;}

		[RED("morphTimeAard")] 		public CFloat MorphTimeAard { get; set;}

		[RED("burnoutTime")] 		public CFloat BurnoutTime { get; set;}

		[RED("igniReactionEffect")] 		public CName IgniReactionEffect { get; set;}

		[RED("aardReactionEffect")] 		public CName AardReactionEffect { get; set;}

		[RED("onDestroyedFact", 2,0)] 		public CArray<CName> OnDestroyedFact { get; set;}

		public W3ArachasEggCustom(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ArachasEggCustom(cr2w);

	}
}