using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceConnectionsHighlightSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("highlightedConnectionsIDs")] public CArray<entEntityID> HighlightedConnectionsIDs { get; set; }
		[Ordinal(1)]  [RED("highlightedDeviceID")] public entEntityID HighlightedDeviceID { get; set; }

		public DeviceConnectionsHighlightSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
