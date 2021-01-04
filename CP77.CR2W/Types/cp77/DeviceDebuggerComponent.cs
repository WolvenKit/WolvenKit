using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeviceDebuggerComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("cachedContext")] public CString CachedContext { get; set; }
		[Ordinal(1)]  [RED("currentDeviceProperties")] public DebuggerProperties CurrentDeviceProperties { get; set; }
		[Ordinal(2)]  [RED("debuggedDevice")] public wCHandle<Device> DebuggedDevice { get; set; }
		[Ordinal(3)]  [RED("debuggerColor")] public CEnum<EDebuggerColor> DebuggerColor { get; set; }
		[Ordinal(4)]  [RED("exclusiveModeTriggered")] public CBool ExclusiveModeTriggered { get; set; }
		[Ordinal(5)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(6)]  [RED("layerIDs")] public CArray<CUInt32> LayerIDs { get; set; }
		[Ordinal(7)]  [RED("previousContext")] public CString PreviousContext { get; set; }

		public DeviceDebuggerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
