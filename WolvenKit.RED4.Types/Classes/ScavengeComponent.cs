using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScavengeComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("scavengeTargets")] 
		public CArray<CWeakHandle<gameObject>> ScavengeTargets
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		public ScavengeComponent()
		{
			ScavengeTargets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
