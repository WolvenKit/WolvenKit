using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEncounterActionPointSelectorPairScr : CVariable
	{
		[RED("category")] 		public SWorkCategoryWrapper Category { get; set;}

		[RED("chance")] 		public CFloat Chance { get; set;}

		public SEncounterActionPointSelectorPairScr(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SEncounterActionPointSelectorPairScr(cr2w);

	}
}