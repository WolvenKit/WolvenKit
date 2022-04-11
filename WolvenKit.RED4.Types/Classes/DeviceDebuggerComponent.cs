using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceDebuggerComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("exclusiveModeTriggered")] 
		public CBool ExclusiveModeTriggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("currentDeviceProperties")] 
		public DebuggerProperties CurrentDeviceProperties
		{
			get => GetPropertyValue<DebuggerProperties>();
			set => SetPropertyValue<DebuggerProperties>(value);
		}

		[Ordinal(8)] 
		[RED("debuggedDevice")] 
		public CWeakHandle<Device> DebuggedDevice
		{
			get => GetPropertyValue<CWeakHandle<Device>>();
			set => SetPropertyValue<CWeakHandle<Device>>(value);
		}

		[Ordinal(9)] 
		[RED("debuggerColor")] 
		public CEnum<EDebuggerColor> DebuggerColor
		{
			get => GetPropertyValue<CEnum<EDebuggerColor>>();
			set => SetPropertyValue<CEnum<EDebuggerColor>>(value);
		}

		[Ordinal(10)] 
		[RED("previousContext")] 
		public CString PreviousContext
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("cachedContext")] 
		public CString CachedContext
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("layerIDs")] 
		public CArray<CUInt32> LayerIDs
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public DeviceDebuggerComponent()
		{
			CurrentDeviceProperties = new() { LayerIDs = new() };
			PreviousContext = "NONE";
			CachedContext = "NONE";
			LayerIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
