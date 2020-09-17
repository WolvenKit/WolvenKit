using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4EnchantingMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("m_fxEnableRemovingEnchantment")] 		public CHandle<CScriptedFlashFunction> M_fxEnableRemovingEnchantment { get; set;}

		[Ordinal(2)] [RED("m_fxEnableEnchantment")] 		public CHandle<CScriptedFlashFunction> M_fxEnableEnchantment { get; set;}

		[Ordinal(3)] [RED("m_fxSetFilters")] 		public CHandle<CScriptedFlashFunction> M_fxSetFilters { get; set;}

		[Ordinal(4)] [RED("m_fxSetLocalization")] 		public CHandle<CScriptedFlashFunction> M_fxSetLocalization { get; set;}

		[Ordinal(5)] [RED("m_fxStartApplying")] 		public CHandle<CScriptedFlashFunction> M_fxStartApplying { get; set;}

		[Ordinal(6)] [RED("m_fxStartRemoving")] 		public CHandle<CScriptedFlashFunction> M_fxStartRemoving { get; set;}

		[Ordinal(7)] [RED("m_fxSelectFirstEnchantment")] 		public CHandle<CScriptedFlashFunction> M_fxSelectFirstEnchantment { get; set;}

		[Ordinal(8)] [RED("m_fxSetPinnedRecipe")] 		public CHandle<CScriptedFlashFunction> M_fxSetPinnedRecipe { get; set;}

		[Ordinal(9)] [RED("m_definitionsManager")] 		public CHandle<CDefinitionsManagerAccessor> M_definitionsManager { get; set;}

		[Ordinal(10)] [RED("m_tooltipDataProvider")] 		public CHandle<W3TooltipComponent> M_tooltipDataProvider { get; set;}

		[Ordinal(11)] [RED("m_playerInvComponent")] 		public CHandle<W3GuiEnchantingInventoryComponent> M_playerInvComponent { get; set;}

		[Ordinal(12)] [RED("m_playerInventory")] 		public CHandle<CInventoryComponent> M_playerInventory { get; set;}

		[Ordinal(13)] [RED("m_enchanterInventory")] 		public CHandle<CInventoryComponent> M_enchanterInventory { get; set;}

		[Ordinal(14)] [RED("m_enchanterNpc")] 		public CHandle<CNewNPC> M_enchanterNpc { get; set;}

		[Ordinal(15)] [RED("m_craftsmanComponent")] 		public CHandle<W3CraftsmanComponent> M_craftsmanComponent { get; set;}

		[Ordinal(16)] [RED("m_enchantmentManager")] 		public CHandle<W3EnchantmentManager> M_enchantmentManager { get; set;}

		[Ordinal(17)] [RED("m_runewordsList", 2,0)] 		public CArray<CName> M_runewordsList { get; set;}

		[Ordinal(18)] [RED("m_glyphwordsList", 2,0)] 		public CArray<CName> M_glyphwordsList { get; set;}

		[Ordinal(19)] [RED("m_allWordsList", 2,0)] 		public CArray<CName> M_allWordsList { get; set;}

		[Ordinal(20)] [RED("m_runewordsData")] 		public CHandle<CScriptedFlashArray> M_runewordsData { get; set;}

		[Ordinal(21)] [RED("m_glyphwordsData")] 		public CHandle<CScriptedFlashArray> M_glyphwordsData { get; set;}

		[Ordinal(22)] [RED("m_allwordsData")] 		public CHandle<CScriptedFlashArray> M_allwordsData { get; set;}

		[Ordinal(23)] [RED("m_initDataConfirmation")] 		public CHandle<EnchantingConfirmationPopupData> M_initDataConfirmation { get; set;}

		[Ordinal(24)] [RED("m_selectedEnchantment")] 		public CName M_selectedEnchantment { get; set;}

		[Ordinal(25)] [RED("m_readonly")] 		public CBool M_readonly { get; set;}

		[Ordinal(26)] [RED("m_notEnoughSlots")] 		public CBool M_notEnoughSlots { get; set;}

		[Ordinal(27)] [RED("m_prevItem")] 		public SItemUniqueId M_prevItem { get; set;}

		[Ordinal(28)] [RED("TYPE_RUNEWORD")] 		public CInt32 TYPE_RUNEWORD { get; set;}

		[Ordinal(29)] [RED("TYPE_GLYPHWORD")] 		public CInt32 TYPE_GLYPHWORD { get; set;}

		[Ordinal(30)] [RED("tutorialTriggered")] 		public CBool TutorialTriggered { get; set;}

		public CR4EnchantingMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4EnchantingMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}