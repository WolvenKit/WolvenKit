using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestGraph : CObject
	{
		[RED("graphBlocks", 2,0)] 		public CArray<CPtr<CGraphBlock>> GraphBlocks { get; set;}

		[RED("sourceDataRemoved")] 		public CBool SourceDataRemoved { get; set;}

		[RED("isTest")] 		public CBool IsTest { get; set;}

		public CQuestGraph(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestGraph(cr2w);

	}
}