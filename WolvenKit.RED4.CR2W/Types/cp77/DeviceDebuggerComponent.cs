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
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("exclusiveModeTriggered")] 
		public CBool ExclusiveModeTriggered
		{
			get
			{
				if (_exclusiveModeTriggered == null)
				{
					_exclusiveModeTriggered = (CBool) CR2WTypeManager.Create("Bool", "exclusiveModeTriggered", cr2w, this);
				}
				return _exclusiveModeTriggered;
			}
			set
			{
				if (_exclusiveModeTriggered == value)
				{
					return;
				}
				_exclusiveModeTriggered = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("currentDeviceProperties")] 
		public DebuggerProperties CurrentDeviceProperties
		{
			get
			{
				if (_currentDeviceProperties == null)
				{
					_currentDeviceProperties = (DebuggerProperties) CR2WTypeManager.Create("DebuggerProperties", "currentDeviceProperties", cr2w, this);
				}
				return _currentDeviceProperties;
			}
			set
			{
				if (_currentDeviceProperties == value)
				{
					return;
				}
				_currentDeviceProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("debuggedDevice")] 
		public wCHandle<Device> DebuggedDevice
		{
			get
			{
				if (_debuggedDevice == null)
				{
					_debuggedDevice = (wCHandle<Device>) CR2WTypeManager.Create("whandle:Device", "debuggedDevice", cr2w, this);
				}
				return _debuggedDevice;
			}
			set
			{
				if (_debuggedDevice == value)
				{
					return;
				}
				_debuggedDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("debuggerColor")] 
		public CEnum<EDebuggerColor> DebuggerColor
		{
			get
			{
				if (_debuggerColor == null)
				{
					_debuggerColor = (CEnum<EDebuggerColor>) CR2WTypeManager.Create("EDebuggerColor", "debuggerColor", cr2w, this);
				}
				return _debuggerColor;
			}
			set
			{
				if (_debuggerColor == value)
				{
					return;
				}
				_debuggerColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("previousContext")] 
		public CString PreviousContext
		{
			get
			{
				if (_previousContext == null)
				{
					_previousContext = (CString) CR2WTypeManager.Create("String", "previousContext", cr2w, this);
				}
				return _previousContext;
			}
			set
			{
				if (_previousContext == value)
				{
					return;
				}
				_previousContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("cachedContext")] 
		public CString CachedContext
		{
			get
			{
				if (_cachedContext == null)
				{
					_cachedContext = (CString) CR2WTypeManager.Create("String", "cachedContext", cr2w, this);
				}
				return _cachedContext;
			}
			set
			{
				if (_cachedContext == value)
				{
					return;
				}
				_cachedContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("layerIDs")] 
		public CArray<CUInt32> LayerIDs
		{
			get
			{
				if (_layerIDs == null)
				{
					_layerIDs = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "layerIDs", cr2w, this);
				}
				return _layerIDs;
			}
			set
			{
				if (_layerIDs == value)
				{
					return;
				}
				_layerIDs = value;
				PropertySet(this);
			}
		}

		public DeviceDebuggerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
