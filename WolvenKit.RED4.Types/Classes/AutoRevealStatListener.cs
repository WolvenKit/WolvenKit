using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AutoRevealStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public AutoRevealStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
