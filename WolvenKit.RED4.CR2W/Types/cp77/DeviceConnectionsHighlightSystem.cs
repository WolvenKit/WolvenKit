using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceConnectionsHighlightSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("highlightedDeviceID")] public entEntityID HighlightedDeviceID { get; set; }
		[Ordinal(1)] [RED("highlightedConnectionsIDs")] public CArray<entEntityID> HighlightedConnectionsIDs { get; set; }

		public DeviceConnectionsHighlightSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
