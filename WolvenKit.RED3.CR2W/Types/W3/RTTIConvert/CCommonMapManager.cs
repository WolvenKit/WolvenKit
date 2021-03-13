using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCommonMapManager : IGameSystem
	{
		[Ordinal(1)] [RED("m_destinationPinTag")] 		public CName M_destinationPinTag { get; set;}

		[Ordinal(2)] [RED("m_debugTeleportWaypointTag")] 		public CName M_debugTeleportWaypointTag { get; set;}

		[Ordinal(3)] [RED("m_noSaveLock")] 		public CInt32 M_noSaveLock { get; set;}

		[Ordinal(4)] [RED("m_dbgShowKnownPins")] 		public CBool M_dbgShowKnownPins { get; set;}

		[Ordinal(5)] [RED("m_dbgShowPins")] 		public CBool M_dbgShowPins { get; set;}

		[Ordinal(6)] [RED("m_dbgShowAllFT")] 		public CBool M_dbgShowAllFT { get; set;}

		[Ordinal(7)] [RED("m_dbgAllowFT")] 		public CBool M_dbgAllowFT { get; set;}

		[Ordinal(8)] [RED("m_borderTeleportPosition")] 		public Vector M_borderTeleportPosition { get; set;}

		[Ordinal(9)] [RED("m_borderTeleportRotation")] 		public EulerAngles M_borderTeleportRotation { get; set;}

		[Ordinal(10)] [RED("m_lastGlobalFastTravelArea")] 		public CInt32 M_lastGlobalFastTravelArea { get; set;}

		[Ordinal(11)] [RED("m_lastGlobalFastTravelPosition")] 		public Vector M_lastGlobalFastTravelPosition { get; set;}

		public CCommonMapManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCommonMapManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}