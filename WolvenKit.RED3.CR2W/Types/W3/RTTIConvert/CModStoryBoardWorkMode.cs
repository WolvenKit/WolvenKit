using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardWorkMode : CObject
	{
		[Ordinal(1)] [RED("workMode")] 		public CName WorkMode { get; set;}

		[Ordinal(2)] [RED("workContext")] 		public CName WorkContext { get; set;}

		[Ordinal(3)] [RED("generalHelpKey")] 		public CString GeneralHelpKey { get; set;}

		[Ordinal(4)] [RED("shot")] 		public CHandle<CModStoryBoardShot> Shot { get; set;}

		[Ordinal(5)] [RED("log")] 		public CHandle<CModLogger> Log { get; set;}

		[Ordinal(6)] [RED("parentCallback")] 		public CHandle<CModSbUiParentCallback> ParentCallback { get; set;}

		public CModStoryBoardWorkMode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardWorkMode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}