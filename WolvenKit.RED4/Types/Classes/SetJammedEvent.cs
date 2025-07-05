using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetJammedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newJammedState")] 
		public CBool NewJammedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public CWeakHandle<gameweaponObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		public SetJammedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
