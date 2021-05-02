using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestGraphBlock : CGraphBlock
	{
		[Ordinal(1)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(2)] [RED("comment")] 		public CString Comment { get; set;}

		[Ordinal(3)] [RED("forceKeepLoadingScreen")] 		public CBool ForceKeepLoadingScreen { get; set;}

		[Ordinal(4)] [RED("guid")] 		public CGUID Guid { get; set;}

		[Ordinal(5)] [RED("cachedConnections", 2,0)] 		public CArray<SCachedConnections> CachedConnections { get; set;}

		[Ordinal(6)] [RED("hasPatchOutput")] 		public CBool HasPatchOutput { get; set;}

		[Ordinal(7)] [RED("hasTerminationInput")] 		public CBool HasTerminationInput { get; set;}

		public CQuestGraphBlock(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestGraphBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}