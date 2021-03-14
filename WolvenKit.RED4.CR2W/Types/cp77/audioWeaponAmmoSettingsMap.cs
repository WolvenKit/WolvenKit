using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponAmmoSettingsMap : audioAudioMetadata
	{
		private audioFlybySettings _standardFlyby;
		private audioFlybySettings _sniperFlyby;
		private audioFlybySettings _shotFlyby;
		private audioFlybySettings _railFlyby;
		private audioFlybySettings _automaticFlyby;
		private audioFlybySettings _smartFlyby;
		private audioFlybySettings _smartSniperFlyby;
		private audioFlybySettings _hmgFlyby;
		private CFloat _flybyMinDistance;

		[Ordinal(1)] 
		[RED("standardFlyby")] 
		public audioFlybySettings StandardFlyby
		{
			get
			{
				if (_standardFlyby == null)
				{
					_standardFlyby = (audioFlybySettings) CR2WTypeManager.Create("audioFlybySettings", "standardFlyby", cr2w, this);
				}
				return _standardFlyby;
			}
			set
			{
				if (_standardFlyby == value)
				{
					return;
				}
				_standardFlyby = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sniperFlyby")] 
		public audioFlybySettings SniperFlyby
		{
			get
			{
				if (_sniperFlyby == null)
				{
					_sniperFlyby = (audioFlybySettings) CR2WTypeManager.Create("audioFlybySettings", "sniperFlyby", cr2w, this);
				}
				return _sniperFlyby;
			}
			set
			{
				if (_sniperFlyby == value)
				{
					return;
				}
				_sniperFlyby = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("shotFlyby")] 
		public audioFlybySettings ShotFlyby
		{
			get
			{
				if (_shotFlyby == null)
				{
					_shotFlyby = (audioFlybySettings) CR2WTypeManager.Create("audioFlybySettings", "shotFlyby", cr2w, this);
				}
				return _shotFlyby;
			}
			set
			{
				if (_shotFlyby == value)
				{
					return;
				}
				_shotFlyby = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("railFlyby")] 
		public audioFlybySettings RailFlyby
		{
			get
			{
				if (_railFlyby == null)
				{
					_railFlyby = (audioFlybySettings) CR2WTypeManager.Create("audioFlybySettings", "railFlyby", cr2w, this);
				}
				return _railFlyby;
			}
			set
			{
				if (_railFlyby == value)
				{
					return;
				}
				_railFlyby = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("automaticFlyby")] 
		public audioFlybySettings AutomaticFlyby
		{
			get
			{
				if (_automaticFlyby == null)
				{
					_automaticFlyby = (audioFlybySettings) CR2WTypeManager.Create("audioFlybySettings", "automaticFlyby", cr2w, this);
				}
				return _automaticFlyby;
			}
			set
			{
				if (_automaticFlyby == value)
				{
					return;
				}
				_automaticFlyby = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("smartFlyby")] 
		public audioFlybySettings SmartFlyby
		{
			get
			{
				if (_smartFlyby == null)
				{
					_smartFlyby = (audioFlybySettings) CR2WTypeManager.Create("audioFlybySettings", "smartFlyby", cr2w, this);
				}
				return _smartFlyby;
			}
			set
			{
				if (_smartFlyby == value)
				{
					return;
				}
				_smartFlyby = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("smartSniperFlyby")] 
		public audioFlybySettings SmartSniperFlyby
		{
			get
			{
				if (_smartSniperFlyby == null)
				{
					_smartSniperFlyby = (audioFlybySettings) CR2WTypeManager.Create("audioFlybySettings", "smartSniperFlyby", cr2w, this);
				}
				return _smartSniperFlyby;
			}
			set
			{
				if (_smartSniperFlyby == value)
				{
					return;
				}
				_smartSniperFlyby = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hmgFlyby")] 
		public audioFlybySettings HmgFlyby
		{
			get
			{
				if (_hmgFlyby == null)
				{
					_hmgFlyby = (audioFlybySettings) CR2WTypeManager.Create("audioFlybySettings", "hmgFlyby", cr2w, this);
				}
				return _hmgFlyby;
			}
			set
			{
				if (_hmgFlyby == value)
				{
					return;
				}
				_hmgFlyby = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("flybyMinDistance")] 
		public CFloat FlybyMinDistance
		{
			get
			{
				if (_flybyMinDistance == null)
				{
					_flybyMinDistance = (CFloat) CR2WTypeManager.Create("Float", "flybyMinDistance", cr2w, this);
				}
				return _flybyMinDistance;
			}
			set
			{
				if (_flybyMinDistance == value)
				{
					return;
				}
				_flybyMinDistance = value;
				PropertySet(this);
			}
		}

		public audioWeaponAmmoSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
