using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkAreaControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("currentlyAvailableCharges")] public CInt32 CurrentlyAvailableCharges { get; set; }
		[Ordinal(1)]  [RED("hudActivated")] public CBool HudActivated { get; set; }
		[Ordinal(2)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(3)]  [RED("maxAvailableCharges")] public CInt32 MaxAvailableCharges { get; set; }
		[Ordinal(4)]  [RED("visualizerID")] public CUInt32 VisualizerID { get; set; }

		public NetworkAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
