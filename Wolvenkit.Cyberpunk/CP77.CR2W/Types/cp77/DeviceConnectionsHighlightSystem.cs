using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceConnectionsHighlightSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("highlightedConnectionsIDs")] public CArray<entEntityID> HighlightedConnectionsIDs { get; set; }
		[Ordinal(1)]  [RED("highlightedDeviceID")] public entEntityID HighlightedDeviceID { get; set; }

		public DeviceConnectionsHighlightSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
