using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardItemStateData : CVariable
	{
		[Ordinal(0)] [RED("("id")] 		public CString Id { get; set;}

		[Ordinal(0)] [RED("("assetname")] 		public CString Assetname { get; set;}

		[Ordinal(0)] [RED("("userSetName")] 		public CBool UserSetName { get; set;}

		[Ordinal(0)] [RED("("templatePath")] 		public CString TemplatePath { get; set;}

		public SStoryBoardItemStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStoryBoardItemStateData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}