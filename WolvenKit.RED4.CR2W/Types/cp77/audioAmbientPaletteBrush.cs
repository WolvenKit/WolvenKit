using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientPaletteBrush : CVariable
	{
		private CFloat _distributionBucketSize;
		private CFloat _virtualHearingRadius;
		private CFloat _hearingDistanceCooldown;
		private CArray<CName> _eventsPool;
		private CName _radioStationMetadata;

		[Ordinal(0)] 
		[RED("distributionBucketSize")] 
		public CFloat DistributionBucketSize
		{
			get
			{
				if (_distributionBucketSize == null)
				{
					_distributionBucketSize = (CFloat) CR2WTypeManager.Create("Float", "distributionBucketSize", cr2w, this);
				}
				return _distributionBucketSize;
			}
			set
			{
				if (_distributionBucketSize == value)
				{
					return;
				}
				_distributionBucketSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("virtualHearingRadius")] 
		public CFloat VirtualHearingRadius
		{
			get
			{
				if (_virtualHearingRadius == null)
				{
					_virtualHearingRadius = (CFloat) CR2WTypeManager.Create("Float", "virtualHearingRadius", cr2w, this);
				}
				return _virtualHearingRadius;
			}
			set
			{
				if (_virtualHearingRadius == value)
				{
					return;
				}
				_virtualHearingRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hearingDistanceCooldown")] 
		public CFloat HearingDistanceCooldown
		{
			get
			{
				if (_hearingDistanceCooldown == null)
				{
					_hearingDistanceCooldown = (CFloat) CR2WTypeManager.Create("Float", "hearingDistanceCooldown", cr2w, this);
				}
				return _hearingDistanceCooldown;
			}
			set
			{
				if (_hearingDistanceCooldown == value)
				{
					return;
				}
				_hearingDistanceCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("eventsPool")] 
		public CArray<CName> EventsPool
		{
			get
			{
				if (_eventsPool == null)
				{
					_eventsPool = (CArray<CName>) CR2WTypeManager.Create("array:CName", "eventsPool", cr2w, this);
				}
				return _eventsPool;
			}
			set
			{
				if (_eventsPool == value)
				{
					return;
				}
				_eventsPool = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("radioStationMetadata")] 
		public CName RadioStationMetadata
		{
			get
			{
				if (_radioStationMetadata == null)
				{
					_radioStationMetadata = (CName) CR2WTypeManager.Create("CName", "radioStationMetadata", cr2w, this);
				}
				return _radioStationMetadata;
			}
			set
			{
				if (_radioStationMetadata == value)
				{
					return;
				}
				_radioStationMetadata = value;
				PropertySet(this);
			}
		}

		public audioAmbientPaletteBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
