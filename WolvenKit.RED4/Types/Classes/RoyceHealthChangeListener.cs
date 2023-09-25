using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RoyceHealthChangeListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("royceComponent")] 
		public CHandle<RoyceComponent> RoyceComponent
		{
			get => GetPropertyValue<CHandle<RoyceComponent>>();
			set => SetPropertyValue<CHandle<RoyceComponent>>(value);
		}

		[Ordinal(2)] 
		[RED("weakspots")] 
		public CArray<CWeakHandle<gameWeakspotObject>> Weakspots
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameWeakspotObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameWeakspotObject>>>(value);
		}

		public RoyceHealthChangeListener()
		{
			Weakspots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
