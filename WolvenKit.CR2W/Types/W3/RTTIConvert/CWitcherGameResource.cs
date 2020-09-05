using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWitcherGameResource : CCommonGameResource
	{
		[Ordinal(1)] [RED("mapPinConfig")] 		public SMapPinConfig MapPinConfig { get; set;}

		[Ordinal(2)] [RED("huntingClueCategoryResource")] 		public CSoft<C2dArray> HuntingClueCategoryResource { get; set;}

		[Ordinal(3)] [RED("journalRootDirectory")] 		public CString JournalRootDirectory { get; set;}

		public CWitcherGameResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWitcherGameResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}