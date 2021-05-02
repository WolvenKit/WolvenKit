using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LeaderboardCustom : W3Poster
	{
		[Ordinal(1)] [RED("m_competitors", 2,0)] 		public CArray<SLeaderBoardData> M_competitors { get; set;}

		[Ordinal(2)] [RED("m_pointSymbolStringKey")] 		public CString M_pointSymbolStringKey { get; set;}

		[Ordinal(3)] [RED("m_displayPointsNumerically")] 		public CBool M_displayPointsNumerically { get; set;}

		[Ordinal(4)] [RED("m_bottom_padding")] 		public CInt32 M_bottom_padding { get; set;}

		[Ordinal(5)] [RED("m_left_padding")] 		public CInt32 M_left_padding { get; set;}

		public W3LeaderboardCustom(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LeaderboardCustom(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}