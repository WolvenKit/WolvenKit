using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestGraphBlock : CGraphBlock
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("comment")] 		public CString Comment { get; set;}

		[RED("forceKeepLoadingScreen")] 		public CBool ForceKeepLoadingScreen { get; set;}

		[RED("guid")] 		public CGUID Guid { get; set;}

		[RED("cachedConnections", 2,0)] 		public CArray<SCachedConnections> CachedConnections { get; set;}

		[RED("hasPatchOutput")] 		public CBool HasPatchOutput { get; set;}

		[RED("hasTerminationInput")] 		public CBool HasTerminationInput { get; set;}

		public CQuestGraphBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestGraphBlock(cr2w);

	}
}