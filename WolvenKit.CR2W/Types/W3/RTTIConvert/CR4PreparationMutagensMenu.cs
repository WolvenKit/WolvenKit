using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PreparationMutagensMenu : CR4MenuBase
	{
		[RED("_gridInv")] 		public CHandle<W3GuiPreparationMutagensInventoryComponent> _gridInv { get; set;}

		[RED("_currentInv")] 		public CHandle<W3GuiBaseInventoryComponent> _currentInv { get; set;}

		[RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[RED("optionsItemActions", 2,0)] 		public CArray<CEnum<EInventoryActionType>> OptionsItemActions { get; set;}

		[RED("_currentQuickSlot")] 		public CEnum<EEquipmentSlots> _currentQuickSlot { get; set;}

		[RED("TOXICTY_BAR_DATA_BINDING_KEY")] 		public CString TOXICTY_BAR_DATA_BINDING_KEY { get; set;}

		[RED("MUTAGENS_SIZE")] 		public CInt32 MUTAGENS_SIZE { get; set;}

		[RED("initialized")] 		public CBool Initialized { get; set;}

		public CR4PreparationMutagensMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PreparationMutagensMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}