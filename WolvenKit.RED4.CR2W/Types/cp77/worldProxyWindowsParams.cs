using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyWindowsParams : CVariable
	{
		private CEnum<worldProxWindowsType> _windowsType;
		private CFloat _distance;
		private CFloat _distanceAboveProxy;
		private CBool _boolean;
		private CFloat _removeSmallerThan;
		private CFloat _distantWindowsEmissive;
		private CFloat _distantWindowsSize;
		private CFloat _distantWindowsSaturation;
		private CFloat _distantWindowsTurnedOf;

		[Ordinal(0)] 
		[RED("windowsType")] 
		public CEnum<worldProxWindowsType> WindowsType
		{
			get
			{
				if (_windowsType == null)
				{
					_windowsType = (CEnum<worldProxWindowsType>) CR2WTypeManager.Create("worldProxWindowsType", "windowsType", cr2w, this);
				}
				return _windowsType;
			}
			set
			{
				if (_windowsType == value)
				{
					return;
				}
				_windowsType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("distanceAboveProxy")] 
		public CFloat DistanceAboveProxy
		{
			get
			{
				if (_distanceAboveProxy == null)
				{
					_distanceAboveProxy = (CFloat) CR2WTypeManager.Create("Float", "distanceAboveProxy", cr2w, this);
				}
				return _distanceAboveProxy;
			}
			set
			{
				if (_distanceAboveProxy == value)
				{
					return;
				}
				_distanceAboveProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boolean")] 
		public CBool Boolean
		{
			get
			{
				if (_boolean == null)
				{
					_boolean = (CBool) CR2WTypeManager.Create("Bool", "boolean", cr2w, this);
				}
				return _boolean;
			}
			set
			{
				if (_boolean == value)
				{
					return;
				}
				_boolean = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("removeSmallerThan")] 
		public CFloat RemoveSmallerThan
		{
			get
			{
				if (_removeSmallerThan == null)
				{
					_removeSmallerThan = (CFloat) CR2WTypeManager.Create("Float", "removeSmallerThan", cr2w, this);
				}
				return _removeSmallerThan;
			}
			set
			{
				if (_removeSmallerThan == value)
				{
					return;
				}
				_removeSmallerThan = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("distantWindowsEmissive")] 
		public CFloat DistantWindowsEmissive
		{
			get
			{
				if (_distantWindowsEmissive == null)
				{
					_distantWindowsEmissive = (CFloat) CR2WTypeManager.Create("Float", "distantWindowsEmissive", cr2w, this);
				}
				return _distantWindowsEmissive;
			}
			set
			{
				if (_distantWindowsEmissive == value)
				{
					return;
				}
				_distantWindowsEmissive = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("distantWindowsSize")] 
		public CFloat DistantWindowsSize
		{
			get
			{
				if (_distantWindowsSize == null)
				{
					_distantWindowsSize = (CFloat) CR2WTypeManager.Create("Float", "distantWindowsSize", cr2w, this);
				}
				return _distantWindowsSize;
			}
			set
			{
				if (_distantWindowsSize == value)
				{
					return;
				}
				_distantWindowsSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("distantWindowsSaturation")] 
		public CFloat DistantWindowsSaturation
		{
			get
			{
				if (_distantWindowsSaturation == null)
				{
					_distantWindowsSaturation = (CFloat) CR2WTypeManager.Create("Float", "distantWindowsSaturation", cr2w, this);
				}
				return _distantWindowsSaturation;
			}
			set
			{
				if (_distantWindowsSaturation == value)
				{
					return;
				}
				_distantWindowsSaturation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("distantWindowsTurnedOf")] 
		public CFloat DistantWindowsTurnedOf
		{
			get
			{
				if (_distantWindowsTurnedOf == null)
				{
					_distantWindowsTurnedOf = (CFloat) CR2WTypeManager.Create("Float", "distantWindowsTurnedOf", cr2w, this);
				}
				return _distantWindowsTurnedOf;
			}
			set
			{
				if (_distantWindowsTurnedOf == value)
				{
					return;
				}
				_distantWindowsTurnedOf = value;
				PropertySet(this);
			}
		}

		public worldProxyWindowsParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
