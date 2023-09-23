using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyDamageEffectorStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CWeakHandle<ModifyDamageEffector> Effector
		{
			get => GetPropertyValue<CWeakHandle<ModifyDamageEffector>>();
			set => SetPropertyValue<CWeakHandle<ModifyDamageEffector>>(value);
		}

		public ModifyDamageEffectorStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
