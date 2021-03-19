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
			get => GetProperty(ref _link);
			set => SetProperty(ref _link, value);
		}

		[Ordinal(1)] 
		[RED("reprimands")] 
		public CArray<ReprimandData> Reprimands
		{
			get => GetProperty(ref _reprimands);
			set => SetProperty(ref _reprimands, value);
		}

		[Ordinal(2)] 
		[RED("supportingAgents")] 
		public CArray<gamePersistentID> SupportingAgents
		{
			get => GetProperty(ref _supportingAgents);
			set => SetProperty(ref _supportingAgents, value);
		}

		[Ordinal(3)] 
		[RED("areas")] 
		public CArray<DeviceLink> Areas
		{
			get => GetProperty(ref _areas);
			set => SetProperty(ref _areas, value);
		}

		[Ordinal(4)] 
		[RED("incomingFilter")] 
		public CEnum<EFilterType> IncomingFilter
		{
			get => GetProperty(ref _incomingFilter);
			set => SetProperty(ref _incomingFilter, value);
		}

		[Ordinal(5)] 
		[RED("cachedDelayDuration")] 
		public CFloat CachedDelayDuration
		{
			get => GetProperty(ref _cachedDelayDuration);
			set => SetProperty(ref _cachedDelayDuration, value);
		}

		public Agent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
