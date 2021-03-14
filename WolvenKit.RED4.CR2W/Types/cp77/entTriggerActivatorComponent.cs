using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTriggerActivatorComponent : entIPlacedComponent
	{
		private CFloat _radius;
		private CFloat _height;
		private CEnum<TriggerChannel> _channels;
		private CFloat _maxContinousDistance;
		private CBool _enableCCD;
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("height")] 
		public CFloat Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CFloat) CR2WTypeManager.Create("Float", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("channels")] 
		public CEnum<TriggerChannel> Channels
		{
			get
			{
				if (_channels == null)
				{
					_channels = (CEnum<TriggerChannel>) CR2WTypeManager.Create("TriggerChannel", "channels", cr2w, this);
				}
				return _channels;
			}
			set
			{
				if (_channels == value)
				{
					return;
				}
				_channels = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("maxContinousDistance")] 
		public CFloat MaxContinousDistance
		{
			get
			{
				if (_maxContinousDistance == null)
				{
					_maxContinousDistance = (CFloat) CR2WTypeManager.Create("Float", "maxContinousDistance", cr2w, this);
				}
				return _maxContinousDistance;
			}
			set
			{
				if (_maxContinousDistance == value)
				{
					return;
				}
				_maxContinousDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("enableCCD")] 
		public CBool EnableCCD
		{
			get
			{
				if (_enableCCD == null)
				{
					_enableCCD = (CBool) CR2WTypeManager.Create("Bool", "enableCCD", cr2w, this);
				}
				return _enableCCD;
			}
			set
			{
				if (_enableCCD == value)
				{
					return;
				}
				_enableCCD = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public entTriggerActivatorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
