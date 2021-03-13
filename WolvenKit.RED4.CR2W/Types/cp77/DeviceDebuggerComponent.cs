using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceDebuggerComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(6)] [RED("exclusiveModeTriggered")] public CBool ExclusiveModeTriggered { get; set; }
		[Ordinal(7)] [RED("currentDeviceProperties")] public DebuggerProperties CurrentDeviceProperties { get; set; }
		[Ordinal(8)] [RED("debuggedDevice")] public wCHandle<Device> DebuggedDevice { get; set; }
		[Ordinal(9)] [RED("debuggerColor")] public CEnum<EDebuggerColor> DebuggerColor { get; set; }
		[Ordinal(10)] [RED("previousContext")] public CString PreviousContext { get; set; }
		[Ordinal(11)] [RED("cachedContext")] public CString CachedContext { get; set; }
		[Ordinal(12)] [RED("layerIDs")] public CArray<CUInt32> LayerIDs { get; set; }

		public DeviceDebuggerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
