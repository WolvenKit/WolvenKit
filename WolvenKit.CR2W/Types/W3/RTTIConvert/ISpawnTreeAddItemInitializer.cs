using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ISpawnTreeAddItemInitializer : ISpawnTreeScriptedInitializer
	{
		[RED("items", 2,0)] 		public CArray<SItemExt> Items { get; set;}

		[RED("randomize")] 		public CBool Randomize { get; set;}

		[RED("equip")] 		public CBool Equip { get; set;}

		[RED("checkIfItemsAlreadyAdded")] 		public CBool CheckIfItemsAlreadyAdded { get; set;}

		public ISpawnTreeAddItemInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ISpawnTreeAddItemInitializer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}