using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimBroadcasterComponent : gameScriptableComponent
	{
		private CArray<CHandle<StimRequest>> _activeRequests;
		private CUInt32 _currentID;
		private CBool _shouldBroadcast;
		private CArray<NPCstubData> _targets;
		private CFloat _fallbackInterval;

		[Ordinal(5)] 
		[RED("activeRequests")] 
		public CArray<CHandle<StimRequest>> ActiveRequests
		{
			get => GetProperty(ref _activeRequests);
			set => SetProperty(ref _activeRequests, value);
		}

		[Ordinal(6)] 
		[RED("currentID")] 
		public CUInt32 CurrentID
		{
			get => GetProperty(ref _currentID);
			set => SetProperty(ref _currentID, value);
		}

		[Ordinal(7)] 
		[RED("shouldBroadcast")] 
		public CBool ShouldBroadcast
		{
			get => GetProperty(ref _shouldBroadcast);
			set => SetProperty(ref _shouldBroadcast, value);
		}

		[Ordinal(8)] 
		[RED("targets")] 
		public CArray<NPCstubData> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(9)] 
		[RED("fallbackInterval")] 
		public CFloat FallbackInterval
		{
			get => GetProperty(ref _fallbackInterval);
			set => SetProperty(ref _fallbackInterval, value);
		}

		public StimBroadcasterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
