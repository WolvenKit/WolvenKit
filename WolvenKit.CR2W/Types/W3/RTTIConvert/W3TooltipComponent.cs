using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TooltipComponent : CObject
	{
		[RED("m_playerInv")] 		public CHandle<CInventoryComponent> M_playerInv { get; set;}

		[RED("m_itemInv")] 		public CHandle<CInventoryComponent> M_itemInv { get; set;}

		[RED("m_shopInv")] 		public CHandle<CInventoryComponent> M_shopInv { get; set;}

		[RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[RED("m_enchantmentManager")] 		public CHandle<W3EnchantmentManager> M_enchantmentManager { get; set;}

		public W3TooltipComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TooltipComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}