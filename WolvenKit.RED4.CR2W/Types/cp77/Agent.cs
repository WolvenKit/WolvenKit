using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Agent : CVariable
	{
		private DeviceLink _link;
		private CArray<ReprimandData> _reprimands;
		private CArray<gamePersistentID> _supportingAgents;
		private CArray<DeviceLink> _areas;
		private CEnum<EFilterType> _incomingFilter;
		private CFloat _cachedDelayDuration;

		[Ordinal(0)] 
		[RED("link")] 
		public DeviceLink Link
		{
			get
			{
				if (_link == null)
				{
					_link = (DeviceLink) CR2WTypeManager.Create("DeviceLink", "link", cr2w, this);
				}
				return _link;
			}
			set
			{
				if (_link == value)
				{
					return;
				}
				_link = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reprimands")] 
		public CArray<ReprimandData> Reprimands
		{
			get
			{
				if (_reprimands == null)
				{
					_reprimands = (CArray<ReprimandData>) CR2WTypeManager.Create("array:ReprimandData", "reprimands", cr2w, this);
				}
				return _reprimands;
			}
			set
			{
				if (_reprimands == value)
				{
					return;
				}
				_reprimands = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("supportingAgents")] 
		public CArray<gamePersistentID> SupportingAgents
		{
			get
			{
				if (_supportingAgents == null)
				{
					_supportingAgents = (CArray<gamePersistentID>) CR2WTypeManager.Create("array:gamePersistentID", "supportingAgents", cr2w, this);
				}
				return _supportingAgents;
			}
			set
			{
				if (_supportingAgents == value)
				{
					return;
				}
				_supportingAgents = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("areas")] 
		public CArray<DeviceLink> Areas
		{
			get
			{
				if (_areas == null)
				{
					_areas = (CArray<DeviceLink>) CR2WTypeManager.Create("array:DeviceLink", "areas", cr2w, this);
				}
				return _areas;
			}
			set
			{
				if (_areas == value)
				{
					return;
				}
				_areas = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("incomingFilter")] 
		public CEnum<EFilterType> IncomingFilter
		{
			get
			{
				if (_incomingFilter == null)
				{
					_incomingFilter = (CEnum<EFilterType>) CR2WTypeManager.Create("EFilterType", "incomingFilter", cr2w, this);
				}
				return _incomingFilter;
			}
			set
			{
				if (_incomingFilter == value)
				{
					return;
				}
				_incomingFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("cachedDelayDuration")] 
		public CFloat CachedDelayDuration
		{
			get
			{
				if (_cachedDelayDuration == null)
				{
					_cachedDelayDuration = (CFloat) CR2WTypeManager.Create("Float", "cachedDelayDuration", cr2w, this);
				}
				return _cachedDelayDuration;
			}
			set
			{
				if (_cachedDelayDuration == value)
				{
					return;
				}
				_cachedDelayDuration = value;
				PropertySet(this);
			}
		}

		public Agent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
