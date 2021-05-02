using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4RyanAlchemyMenu : CR4Menu
	{
		[Ordinal(1)] [RED("KEY_RECIPE_LIST")] 		public CString KEY_RECIPE_LIST { get; set;}

		[Ordinal(2)] [RED("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(3)] [RED("m_alchemyManager")] 		public CHandle<W3AlchemyManager> M_alchemyManager { get; set;}

		[Ordinal(4)] [RED("m_inventory")] 		public CHandle<CInventoryComponent> M_inventory { get; set;}

		[Ordinal(5)] [RED("m_recipeList", 2,0)] 		public CArray<SAlchemyRecipe> M_recipeList { get; set;}

		public CR4RyanAlchemyMenu(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4RyanAlchemyMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}