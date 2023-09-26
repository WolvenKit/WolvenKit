using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReflexesMasterPerk1EffectorListener : gameScriptedDamageSystemListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CHandle<ReflexesMasterPerk1Effector> Owner
		{
			get => GetPropertyValue<CHandle<ReflexesMasterPerk1Effector>>();
			set => SetPropertyValue<CHandle<ReflexesMasterPerk1Effector>>(value);
		}

		public ReflexesMasterPerk1EffectorListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
