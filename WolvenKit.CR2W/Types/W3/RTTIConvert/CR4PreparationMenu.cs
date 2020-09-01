using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PreparationMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("_gridInv")] 		public CHandle<W3GuiPreparationInventoryComponent> _gridInv { get; set;}

		[Ordinal(2)] [RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		public CR4PreparationMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PreparationMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}