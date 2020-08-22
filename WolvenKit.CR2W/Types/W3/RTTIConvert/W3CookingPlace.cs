using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CookingPlace : W3Container
	{
		[RED("cookingTime")] 		public CFloat CookingTime { get; set;}

		[RED("schematics", 2,0)] 		public CArray<SCookingSchematic> Schematics { get; set;}

		[RED("isActive")] 		public CBool IsActive { get; set;}

		[RED("cookingStarted")] 		public CBool CookingStarted { get; set;}

		[RED("cookingCompleted")] 		public CBool CookingCompleted { get; set;}

		[RED("secondaryLootInteractionComponent")] 		public CHandle<CInteractionComponent> SecondaryLootInteractionComponent { get; set;}

		public W3CookingPlace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CookingPlace(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}