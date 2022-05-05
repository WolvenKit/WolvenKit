using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GrenadeQuickhackKillEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("targets")] 
		public CArray<CWeakHandle<gameObject>> Targets
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		[Ordinal(2)] 
		[RED("timestamps")] 
		public CArray<CFloat> Timestamps
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public GrenadeQuickhackKillEntry()
		{
			Targets = new();
			Timestamps = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
