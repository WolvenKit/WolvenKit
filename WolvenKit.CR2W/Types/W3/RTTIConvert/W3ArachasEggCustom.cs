using System.IO;
using System.Runtime.Serialization;
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

		[RED("destroyed")] 		public CBool Destroyed { get; set;}

		[RED("igniReactionEffect")] 		public CName IgniReactionEffect { get; set;}

		[RED("aardReactionEffect")] 		public CName AardReactionEffect { get; set;}

		[RED("onDestroyedFact", 2,0)] 		public CArray<CName> OnDestroyedFact { get; set;}

		[RED("morphManager")] 		public CHandle<CMorphedMeshManagerComponent> MorphManager { get; set;}

		[RED("morphTime")] 		public CFloat MorphTime { get; set;}

		[RED("allowFactAdding")] 		public CBool AllowFactAdding { get; set;}

		[RED("APPEARANCE_INTACT")] 		public CName APPEARANCE_INTACT { get; set;}

		[RED("APPEARANCE_DESTROYED")] 		public CName APPEARANCE_DESTROYED { get; set;}

		public W3ArachasEggCustom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ArachasEggCustom(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}