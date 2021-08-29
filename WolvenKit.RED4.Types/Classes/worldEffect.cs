using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEffect : resStreamedResource
	{
		private CName _name;
		private CFloat _length;
		private CArray<CName> _inputParameterNames;
		private CHandle<effectTrackGroup> _trackRoot;
		private CArray<CHandle<effectTrackItem>> _events;
		private CArray<effectLoopData> _effectLoops;

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(2)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetProperty(ref _length);
			set => SetProperty(ref _length, value);
		}

		[Ordinal(3)] 
		[RED("inputParameterNames")] 
		public CArray<CName> InputParameterNames
		{
			get => GetProperty(ref _inputParameterNames);
			set => SetProperty(ref _inputParameterNames, value);
		}

		[Ordinal(4)] 
		[RED("trackRoot")] 
		public CHandle<effectTrackGroup> TrackRoot
		{
			get => GetProperty(ref _trackRoot);
			set => SetProperty(ref _trackRoot, value);
		}

		[Ordinal(5)] 
		[RED("events")] 
		public CArray<CHandle<effectTrackItem>> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}

		[Ordinal(6)] 
		[RED("effectLoops")] 
		public CArray<effectLoopData> EffectLoops
		{
			get => GetProperty(ref _effectLoops);
			set => SetProperty(ref _effectLoops, value);
		}
	}
}
