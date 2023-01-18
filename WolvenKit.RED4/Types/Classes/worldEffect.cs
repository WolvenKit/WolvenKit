using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldEffect : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("inputParameterNames")] 
		public CArray<CName> InputParameterNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("trackRoot")] 
		public CHandle<effectTrackGroup> TrackRoot
		{
			get => GetPropertyValue<CHandle<effectTrackGroup>>();
			set => SetPropertyValue<CHandle<effectTrackGroup>>(value);
		}

		[Ordinal(5)] 
		[RED("events")] 
		public CArray<CHandle<effectTrackItem>> Events
		{
			get => GetPropertyValue<CArray<CHandle<effectTrackItem>>>();
			set => SetPropertyValue<CArray<CHandle<effectTrackItem>>>(value);
		}

		[Ordinal(6)] 
		[RED("effectLoops")] 
		public CArray<effectLoopData> EffectLoops
		{
			get => GetPropertyValue<CArray<effectLoopData>>();
			set => SetPropertyValue<CArray<effectLoopData>>(value);
		}

		public worldEffect()
		{
			Length = 1.000000F;
			InputParameterNames = new();
			Events = new();
			EffectLoops = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
