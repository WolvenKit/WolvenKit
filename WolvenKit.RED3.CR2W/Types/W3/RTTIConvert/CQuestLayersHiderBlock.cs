using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestLayersHiderBlock : CQuestGraphBlock
	{
		[Ordinal(1)] [RED("world")] 		public CString World { get; set;}

		[Ordinal(2)] [RED("layersToShow", 2,0)] 		public CArray<CString> LayersToShow { get; set;}

		[Ordinal(3)] [RED("layersToHide", 2,0)] 		public CArray<CString> LayersToHide { get; set;}

		[Ordinal(4)] [RED("syncOperation")] 		public CBool SyncOperation { get; set;}

		[Ordinal(5)] [RED("purgeSavedData")] 		public CBool PurgeSavedData { get; set;}

		public CQuestLayersHiderBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestLayersHiderBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}