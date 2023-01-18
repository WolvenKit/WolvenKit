using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameContainerObjectBase : gameLootContainerBase
	{
		[Ordinal(45)] 
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
