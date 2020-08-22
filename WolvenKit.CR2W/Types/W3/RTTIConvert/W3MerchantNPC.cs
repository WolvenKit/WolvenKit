using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MerchantNPC : CNewNPC
	{
		[RED("embeddedScenes", 2,0)] 		public CArray<MerchantNPCEmbeddedScenes> EmbeddedScenes { get; set;}

		[RED("lastDayOfInteraction")] 		public CInt32 LastDayOfInteraction { get; set;}

		[RED("questBonus")] 		public CBool QuestBonus { get; set;}

		[RED("cacheMerchantMappin")] 		public CBool CacheMerchantMappin { get; set;}

		[RED("craftingDisabled")] 		public CBool CraftingDisabled { get; set;}

		[RED("invComp")] 		public CHandle<CInventoryComponent> InvComp { get; set;}

		public W3MerchantNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MerchantNPC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}