using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3CookingPlace : W3Container
	{
		[Ordinal(1)] [RED("cookingTime")] 		public CFloat CookingTime { get; set;}

		[Ordinal(2)] [RED("schematics", 2,0)] 		public CArray<SCookingSchematic> Schematics { get; set;}

		[Ordinal(3)] [RED("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(4)] [RED("cookingStarted")] 		public CBool CookingStarted { get; set;}

		[Ordinal(5)] [RED("cookingCompleted")] 		public CBool CookingCompleted { get; set;}

		[Ordinal(6)] [RED("secondaryLootInteractionComponent")] 		public CHandle<CInteractionComponent> SecondaryLootInteractionComponent { get; set;}

		public W3CookingPlace(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3CookingPlace(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}