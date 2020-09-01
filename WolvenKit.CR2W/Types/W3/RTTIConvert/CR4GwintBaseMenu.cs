using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GwintBaseMenu : CR4MenuBase
	{
		[Ordinal(0)] [RED("("quitConfPopup")] 		public CHandle<W3GwintQuitConfPopup> QuitConfPopup { get; set;}

		[Ordinal(0)] [RED("("gwintManager")] 		public CHandle<CR4GwintManager> GwintManager { get; set;}

		[Ordinal(0)] [RED("("flashConstructor")] 		public CHandle<CScriptedFlashObject> FlashConstructor { get; set;}

		public CR4GwintBaseMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GwintBaseMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}