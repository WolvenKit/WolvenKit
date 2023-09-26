using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickHackQueueItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CHandle<GameplayRoleMappinData> Data
		{
			get => GetPropertyValue<CHandle<GameplayRoleMappinData>>();
			set => SetPropertyValue<CHandle<GameplayRoleMappinData>>(value);
		}

		[Ordinal(3)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public QuickHackQueueItem()
		{
			Icon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
