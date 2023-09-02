using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class GameplayConditionBase : IScriptable
	{
		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public GameplayConditionBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
