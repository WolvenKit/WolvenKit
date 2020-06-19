using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ScentComponent : CR4Component
	{
		[RED("foodGroup")] 		public CEnum<EFoodGroup> FoodGroup { get; set;}

		[RED("attractionRange")] 		public CFloat AttractionRange { get; set;}

		[RED("deadAttractionRange")] 		public CFloat DeadAttractionRange { get; set;}

		[RED("bleedingAttractionRange")] 		public CFloat BleedingAttractionRange { get; set;}

		public W3ScentComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ScentComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}