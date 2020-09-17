using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TooltipComponent : CObject
	{
		[Ordinal(1)] [RED("m_playerInv")] 		public CHandle<CInventoryComponent> M_playerInv { get; set;}

		[Ordinal(2)] [RED("m_itemInv")] 		public CHandle<CInventoryComponent> M_itemInv { get; set;}

		[Ordinal(3)] [RED("m_shopInv")] 		public CHandle<CInventoryComponent> M_shopInv { get; set;}

		[Ordinal(4)] [RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(5)] [RED("m_enchantmentManager")] 		public CHandle<W3EnchantmentManager> M_enchantmentManager { get; set;}

		public W3TooltipComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TooltipComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}