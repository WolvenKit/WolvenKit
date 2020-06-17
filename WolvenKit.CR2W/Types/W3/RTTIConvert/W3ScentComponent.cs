using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ScentComponent : CR4Component
	{
		[RED("foodGroup")] 		public EFoodGroup FoodGroup { get; set;}

		[RED("attractionRange")] 		public CFloat AttractionRange { get; set;}

		[RED("deadAttractionRange")] 		public CFloat DeadAttractionRange { get; set;}

		[RED("bleedingAttractionRange")] 		public CFloat BleedingAttractionRange { get; set;}

		public W3ScentComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ScentComponent(cr2w);

	}
}