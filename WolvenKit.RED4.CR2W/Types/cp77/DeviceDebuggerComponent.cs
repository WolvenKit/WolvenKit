using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceDebuggerComponent : gameScriptableComponent
	{
		private CBool _isActive;
		private CBool _exclusiveModeTriggered;
		private DebuggerProperties _currentDeviceProperties;
		private wCHandle<Device> _debuggedDevice;
		private CEnum<EDebuggerColor> _debuggerColor;
		private CString _previousContext;
		private CString _cachedContext;
		private CArray<CUInt32> _layerIDs;

		[Ordinal(5)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(6)] 
		[RED("exclusiveModeTriggered")] 
		public CBool ExclusiveModeTriggered
		{
			get => GetProperty(ref _exclusiveModeTriggered);
			set => SetProperty(ref _exclusiveModeTriggered, value);
		}

		[Ordinal(7)] 
		[RED("currentDeviceProperties")] 
		public DebuggerProperties CurrentDeviceProperties
		{
			get => GetProperty(ref _currentDeviceProperties);
			set => SetProperty(ref _currentDeviceProperties, value);
		}

		[Ordinal(8)] 
		[RED("debuggedDevice")] 
		public wCHandle<Device> DebuggedDevice
		{
			get => GetProperty(ref _debuggedDevice);
			set => SetProperty(ref _debuggedDevice, value);
		}

		[Ordinal(9)] 
		[RED("debuggerColor")] 
		public CEnum<EDebuggerColor> DebuggerColor
		{
			get => GetProperty(ref _debuggerColor);
			set => SetProperty(ref _debuggerColor, value);
		}

		[Ordinal(10)] 
		[RED("previousContext")] 
		public CString PreviousContext
		{
			get => GetProperty(ref _previousContext);
			set => SetProperty(ref _previousContext, value);
		}

		[Ordinal(11)] 
		[RED("cachedContext")] 
		public CString CachedContext
		{
			get => GetProperty(ref _cachedContext);
			set => SetProperty(ref _cachedContext, value);
		}

		[Ordinal(12)] 
		[RED("layerIDs")] 
		public CArray<CUInt32> LayerIDs
		{
			get => GetProperty(ref _layerIDs);
			set => SetProperty(ref _layerIDs, value);
		}

		public DeviceDebuggerComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
