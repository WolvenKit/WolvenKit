using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamegpsSettings : CVariable
	{
		private raRef<worldEffect> _lineEffectOnFoot;
		private raRef<worldEffect> _lineEffectVehicle;
		private Vector3 _fixedPathOffset;
		private Vector3 _fixedPortalMappinOffset;
		private CFloat _pathRefreshTimeInterval;
		private CFloat _lastPlayerNavmeshPositionRefreshTimeIntervalSecs;
		private CFloat _maxPathDisplayLength;

		[Ordinal(0)] 
		[RED("lineEffectOnFoot")] 
		public raRef<worldEffect> LineEffectOnFoot
		{
			get
			{
				if (_lineEffectOnFoot == null)
				{
					_lineEffectOnFoot = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "lineEffectOnFoot", cr2w, this);
				}
				return _lineEffectOnFoot;
			}
			set
			{
				if (_lineEffectOnFoot == value)
				{
					return;
				}
				_lineEffectOnFoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lineEffectVehicle")] 
		public raRef<worldEffect> LineEffectVehicle
		{
			get
			{
				if (_lineEffectVehicle == null)
				{
					_lineEffectVehicle = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "lineEffectVehicle", cr2w, this);
				}
				return _lineEffectVehicle;
			}
			set
			{
				if (_lineEffectVehicle == value)
				{
					return;
				}
				_lineEffectVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fixedPathOffset")] 
		public Vector3 FixedPathOffset
		{
			get
			{
				if (_fixedPathOffset == null)
				{
					_fixedPathOffset = (Vector3) CR2WTypeManager.Create("Vector3", "fixedPathOffset", cr2w, this);
				}
				return _fixedPathOffset;
			}
			set
			{
				if (_fixedPathOffset == value)
				{
					return;
				}
				_fixedPathOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fixedPortalMappinOffset")] 
		public Vector3 FixedPortalMappinOffset
		{
			get
			{
				if (_fixedPortalMappinOffset == null)
				{
					_fixedPortalMappinOffset = (Vector3) CR2WTypeManager.Create("Vector3", "fixedPortalMappinOffset", cr2w, this);
				}
				return _fixedPortalMappinOffset;
			}
			set
			{
				if (_fixedPortalMappinOffset == value)
				{
					return;
				}
				_fixedPortalMappinOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pathRefreshTimeInterval")] 
		public CFloat PathRefreshTimeInterval
		{
			get
			{
				if (_pathRefreshTimeInterval == null)
				{
					_pathRefreshTimeInterval = (CFloat) CR2WTypeManager.Create("Float", "pathRefreshTimeInterval", cr2w, this);
				}
				return _pathRefreshTimeInterval;
			}
			set
			{
				if (_pathRefreshTimeInterval == value)
				{
					return;
				}
				_pathRefreshTimeInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lastPlayerNavmeshPositionRefreshTimeIntervalSecs")] 
		public CFloat LastPlayerNavmeshPositionRefreshTimeIntervalSecs
		{
			get
			{
				if (_lastPlayerNavmeshPositionRefreshTimeIntervalSecs == null)
				{
					_lastPlayerNavmeshPositionRefreshTimeIntervalSecs = (CFloat) CR2WTypeManager.Create("Float", "lastPlayerNavmeshPositionRefreshTimeIntervalSecs", cr2w, this);
				}
				return _lastPlayerNavmeshPositionRefreshTimeIntervalSecs;
			}
			set
			{
				if (_lastPlayerNavmeshPositionRefreshTimeIntervalSecs == value)
				{
					return;
				}
				_lastPlayerNavmeshPositionRefreshTimeIntervalSecs = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxPathDisplayLength")] 
		public CFloat MaxPathDisplayLength
		{
			get
			{
				if (_maxPathDisplayLength == null)
				{
					_maxPathDisplayLength = (CFloat) CR2WTypeManager.Create("Float", "maxPathDisplayLength", cr2w, this);
				}
				return _maxPathDisplayLength;
			}
			set
			{
				if (_maxPathDisplayLength == value)
				{
					return;
				}
				_maxPathDisplayLength = value;
				PropertySet(this);
			}
		}

		public gamegpsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
