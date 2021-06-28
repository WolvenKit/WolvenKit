using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PreparationMutagensMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("_gridInv")] 		public CHandle<W3GuiPreparationMutagensInventoryComponent> _gridInv { get; set;}

		[Ordinal(2)] [RED("_currentInv")] 		public CHandle<W3GuiBaseInventoryComponent> _currentInv { get; set;}

		[Ordinal(3)] [RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[Ordinal(4)] [RED("optionsItemActions", 2,0)] 		public CArray<CEnum<EInventoryActionType>> OptionsItemActions { get; set;}

		[Ordinal(5)] [RED("_currentQuickSlot")] 		public CEnum<EEquipmentSlots> _currentQuickSlot { get; set;}

		[Ordinal(6)] [RED("TOXICTY_BAR_DATA_BINDING_KEY")] 		public CString TOXICTY_BAR_DATA_BINDING_KEY { get; set;}

		[Ordinal(7)] [RED("MUTAGENS_SIZE")] 		public CInt32 MUTAGENS_SIZE { get; set;}

		[Ordinal(8)] [RED("initialized")] 		public CBool Initialized { get; set;}

		public CR4PreparationMutagensMenu(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}