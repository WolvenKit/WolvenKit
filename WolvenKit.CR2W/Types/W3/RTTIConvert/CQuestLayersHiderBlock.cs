using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestLayersHiderBlock : CQuestGraphBlock
	{
		[RED("world")] 		public CString World { get; set;}

		[RED("layersToShow", 2,0)] 		public CArray<CString> LayersToShow { get; set;}

		[RED("layersToHide", 2,0)] 		public CArray<CString> LayersToHide { get; set;}

		[RED("syncOperation")] 		public CBool SyncOperation { get; set;}

		[RED("purgeSavedData")] 		public CBool PurgeSavedData { get; set;}

		public CQuestLayersHiderBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestLayersHiderBlock(cr2w);

	}
}