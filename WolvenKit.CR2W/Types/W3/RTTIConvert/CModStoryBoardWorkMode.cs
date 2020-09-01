using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardWorkMode : CObject
	{
		[Ordinal(0)] [RED("workMode")] 		public CName WorkMode { get; set;}

		[Ordinal(0)] [RED("workContext")] 		public CName WorkContext { get; set;}

		[Ordinal(0)] [RED("generalHelpKey")] 		public CString GeneralHelpKey { get; set;}

		[Ordinal(0)] [RED("shot")] 		public CHandle<CModStoryBoardShot> Shot { get; set;}

		[Ordinal(0)] [RED("log")] 		public CHandle<CModLogger> Log { get; set;}

		[Ordinal(0)] [RED("parentCallback")] 		public CHandle<CModSbUiParentCallback> ParentCallback { get; set;}

		public CModStoryBoardWorkMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardWorkMode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}