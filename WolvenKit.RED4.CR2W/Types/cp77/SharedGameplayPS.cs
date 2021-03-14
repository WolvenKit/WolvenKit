using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SharedGameplayPS : gameDeviceComponentPS
	{
		private CEnum<EDeviceStatus> _deviceState;
		private AuthorizationData _authorizationProperties;
		private CBool _wasStateCached;
		private CBool _wasStateSet;
		private CEnum<EDeviceStatus> _cachedDeviceState;
		private CBool _revealDevicesGrid;
		private CBool _revealDevicesGridWhenUnpowered;
		private CBool _wasRevealedInNetworkPing;
		private CBool _hasNetworkBackdoor;

		[Ordinal(12)] 
		[RED("deviceState")] 
		public CEnum<EDeviceStatus> DeviceState
		{
			get
			{
				if (_deviceState == null)
				{
					_deviceState = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "deviceState", cr2w, this);
				}
				return _deviceState;
			}
			set
			{
				if (_deviceState == value)
				{
					return;
				}
				_deviceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("authorizationProperties")] 
		public AuthorizationData AuthorizationProperties
		{
			get
			{
				if (_authorizationProperties == null)
				{
					_authorizationProperties = (AuthorizationData) CR2WTypeManager.Create("AuthorizationData", "authorizationProperties", cr2w, this);
				}
				return _authorizationProperties;
			}
			set
			{
				if (_authorizationProperties == value)
				{
					return;
				}
				_authorizationProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get
			{
				if (_wasStateCached == null)
				{
					_wasStateCached = (CBool) CR2WTypeManager.Create("Bool", "wasStateCached", cr2w, this);
				}
				return _wasStateCached;
			}
			set
			{
				if (_wasStateCached == value)
				{
					return;
				}
				_wasStateCached = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("wasStateSet")] 
		public CBool WasStateSet
		{
			get
			{
				if (_wasStateSet == null)
				{
					_wasStateSet = (CBool) CR2WTypeManager.Create("Bool", "wasStateSet", cr2w, this);
				}
				return _wasStateSet;
			}
			set
			{
				if (_wasStateSet == value)
				{
					return;
				}
				_wasStateSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("cachedDeviceState")] 
		public CEnum<EDeviceStatus> CachedDeviceState
		{
			get
			{
				if (_cachedDeviceState == null)
				{
					_cachedDeviceState = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "cachedDeviceState", cr2w, this);
				}
				return _cachedDeviceState;
			}
			set
			{
				if (_cachedDeviceState == value)
				{
					return;
				}
				_cachedDeviceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("revealDevicesGrid")] 
		public CBool RevealDevicesGrid
		{
			get
			{
				if (_revealDevicesGrid == null)
				{
					_revealDevicesGrid = (CBool) CR2WTypeManager.Create("Bool", "revealDevicesGrid", cr2w, this);
				}
				return _revealDevicesGrid;
			}
			set
			{
				if (_revealDevicesGrid == value)
				{
					return;
				}
				_revealDevicesGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("revealDevicesGridWhenUnpowered")] 
		public CBool RevealDevicesGridWhenUnpowered
		{
			get
			{
				if (_revealDevicesGridWhenUnpowered == null)
				{
					_revealDevicesGridWhenUnpowered = (CBool) CR2WTypeManager.Create("Bool", "revealDevicesGridWhenUnpowered", cr2w, this);
				}
				return _revealDevicesGridWhenUnpowered;
			}
			set
			{
				if (_revealDevicesGridWhenUnpowered == value)
				{
					return;
				}
				_revealDevicesGridWhenUnpowered = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("wasRevealedInNetworkPing")] 
		public CBool WasRevealedInNetworkPing
		{
			get
			{
				if (_wasRevealedInNetworkPing == null)
				{
					_wasRevealedInNetworkPing = (CBool) CR2WTypeManager.Create("Bool", "wasRevealedInNetworkPing", cr2w, this);
				}
				return _wasRevealedInNetworkPing;
			}
			set
			{
				if (_wasRevealedInNetworkPing == value)
				{
					return;
				}
				_wasRevealedInNetworkPing = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("hasNetworkBackdoor")] 
		public CBool HasNetworkBackdoor
		{
			get
			{
				if (_hasNetworkBackdoor == null)
				{
					_hasNetworkBackdoor = (CBool) CR2WTypeManager.Create("Bool", "hasNetworkBackdoor", cr2w, this);
				}
				return _hasNetworkBackdoor;
			}
			set
			{
				if (_hasNetworkBackdoor == value)
				{
					return;
				}
				_hasNetworkBackdoor = value;
				PropertySet(this);
			}
		}

		public SharedGameplayPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
