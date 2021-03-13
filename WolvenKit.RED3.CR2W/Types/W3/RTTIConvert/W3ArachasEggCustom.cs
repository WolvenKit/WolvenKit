using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ArachasEggCustom : W3MonsterClue
	{
		[Ordinal(1)] [RED("morphTimeIgni")] 		public CFloat MorphTimeIgni { get; set;}

		[Ordinal(2)] [RED("morphTimeAard")] 		public CFloat MorphTimeAard { get; set;}

		[Ordinal(3)] [RED("burnoutTime")] 		public CFloat BurnoutTime { get; set;}

		[Ordinal(4)] [RED("destroyed")] 		public CBool Destroyed { get; set;}

		[Ordinal(5)] [RED("igniReactionEffect")] 		public CName IgniReactionEffect { get; set;}

		[Ordinal(6)] [RED("aardReactionEffect")] 		public CName AardReactionEffect { get; set;}

		[Ordinal(7)] [RED("onDestroyedFact", 2,0)] 		public CArray<CName> OnDestroyedFact { get; set;}

		[Ordinal(8)] [RED("morphManager")] 		public CHandle<CMorphedMeshManagerComponent> MorphManager { get; set;}

		[Ordinal(9)] [RED("morphTime")] 		public CFloat MorphTime { get; set;}

		[Ordinal(10)] [RED("allowFactAdding")] 		public CBool AllowFactAdding { get; set;}

		[Ordinal(11)] [RED("APPEARANCE_INTACT")] 		public CName APPEARANCE_INTACT { get; set;}

		[Ordinal(12)] [RED("APPEARANCE_DESTROYED")] 		public CName APPEARANCE_DESTROYED { get; set;}

		public W3ArachasEggCustom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ArachasEggCustom(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}