using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModulePickedItemsInfo : CR4HudModuleBase
	{
		[Ordinal(1)] [RED("_RecentlyAddedItemListSize")] 		public CInt32 _RecentlyAddedItemListSize { get; set;}

		[Ordinal(2)] [RED("bCurrentShowState")] 		public CBool BCurrentShowState { get; set;}

		[Ordinal(3)] [RED("bShouldShowElement")] 		public CBool BShouldShowElement { get; set;}

		[Ordinal(4)] [RED("_PickedItemListSize")] 		public CInt32 _PickedItemListSize { get; set;}

		public CR4HudModulePickedItemsInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModulePickedItemsInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}