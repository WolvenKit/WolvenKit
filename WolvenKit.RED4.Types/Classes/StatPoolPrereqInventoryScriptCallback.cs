using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolPrereqInventoryScriptCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CWeakHandle<StatPoolPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<StatPoolPrereqState>>();
			set => SetPropertyValue<CWeakHandle<StatPoolPrereqState>>(value);
		}

		public StatPoolPrereqInventoryScriptCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
