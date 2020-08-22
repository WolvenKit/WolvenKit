using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCommonMapManager : IGameSystem
	{
		[RED("m_destinationPinTag")] 		public CName M_destinationPinTag { get; set;}

		[RED("m_debugTeleportWaypointTag")] 		public CName M_debugTeleportWaypointTag { get; set;}

		[RED("m_noSaveLock")] 		public CInt32 M_noSaveLock { get; set;}

		[RED("m_dbgShowKnownPins")] 		public CBool M_dbgShowKnownPins { get; set;}

		[RED("m_dbgShowPins")] 		public CBool M_dbgShowPins { get; set;}

		[RED("m_dbgShowAllFT")] 		public CBool M_dbgShowAllFT { get; set;}

		[RED("m_dbgAllowFT")] 		public CBool M_dbgAllowFT { get; set;}

		[RED("m_borderTeleportPosition")] 		public Vector M_borderTeleportPosition { get; set;}

		[RED("m_borderTeleportRotation")] 		public EulerAngles M_borderTeleportRotation { get; set;}

		[RED("m_lastGlobalFastTravelArea")] 		public CInt32 M_lastGlobalFastTravelArea { get; set;}

		[RED("m_lastGlobalFastTravelPosition")] 		public Vector M_lastGlobalFastTravelPosition { get; set;}

		public CCommonMapManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCommonMapManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}