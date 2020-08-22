using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PreparationPotionsAndBombsMenu : CR4MenuBase
	{
		[RED("_gridInv")] 		public CHandle<W3GuiPreparationPotionsAndBombsInventoryComponent> _gridInv { get; set;}

		[RED("_currentInv")] 		public CHandle<W3GuiBaseInventoryComponent> _currentInv { get; set;}

		[RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[RED("optionsItemActions", 2,0)] 		public CArray<CEnum<EInventoryActionType>> OptionsItemActions { get; set;}

		[RED("_currentQuickSlot")] 		public CEnum<EEquipmentSlots> _currentQuickSlot { get; set;}

		[RED("ITEMS_SIZE")] 		public CInt32 ITEMS_SIZE { get; set;}

		public CR4PreparationPotionsAndBombsMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PreparationPotionsAndBombsMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}