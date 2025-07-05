using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameContainerObjectBase : gameLootContainerBase
	{
		[Ordinal(47)] 
		[RED("giveHandicapAmmo")] 
		public CBool GiveHandicapAmmo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("lockedByKey")] 
		public TweakDBID LockedByKey
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameContainerObjectBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
