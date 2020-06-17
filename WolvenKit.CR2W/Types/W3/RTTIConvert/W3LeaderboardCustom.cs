using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LeaderboardCustom : W3Poster
	{
		[RED("m_competitors", 2,0)] 		public CArray<SLeaderBoardData> M_competitors { get; set;}

		[RED("m_pointSymbolStringKey")] 		public CString M_pointSymbolStringKey { get; set;}

		[RED("m_displayPointsNumerically")] 		public CBool M_displayPointsNumerically { get; set;}

		[RED("m_bottom_padding")] 		public CInt32 M_bottom_padding { get; set;}

		[RED("m_left_padding")] 		public CInt32 M_left_padding { get; set;}

		public W3LeaderboardCustom(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3LeaderboardCustom(cr2w);

	}
}