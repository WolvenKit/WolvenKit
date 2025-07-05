using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksPerkItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("iconGhost")] 
		public inkImageWidgetReference IconGhost
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("lockIcon")] 
		public inkWidgetReference LockIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("requiredPointsText")] 
		public inkTextWidgetReference RequiredPointsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("DEV_notYetImplemented")] 
		public inkWidgetReference DEV_notYetImplemented
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("container")] 
		public CWeakHandle<NewPerksPerkContainerLogicController> Container
		{
			get => GetPropertyValue<CWeakHandle<NewPerksPerkContainerLogicController>>();
			set => SetPropertyValue<CWeakHandle<NewPerksPerkContainerLogicController>>(value);
		}

		[Ordinal(8)] 
		[RED("initData")] 
		public CHandle<NewPerksPerkItemInitData> InitData
		{
			get => GetPropertyValue<CHandle<NewPerksPerkItemInitData>>();
			set => SetPropertyValue<CHandle<NewPerksPerkItemInitData>>(value);
		}

		[Ordinal(9)] 
		[RED("isUnlocked")] 
		public CBool IsUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("maxedAnimProxy")] 
		public CHandle<inkanimProxy> MaxedAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(13)] 
		[RED("animProxies")] 
		public CArray<CHandle<inkanimProxy>> AnimProxies
		{
			get => GetPropertyValue<CArray<CHandle<inkanimProxy>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimProxy>>>(value);
		}

		[Ordinal(14)] 
		[RED("isRelic")] 
		public CBool IsRelic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NewPerksPerkItemLogicController()
		{
			Icon = new inkImageWidgetReference();
			IconGhost = new inkImageWidgetReference();
			LockIcon = new inkWidgetReference();
			RequiredPointsText = new inkTextWidgetReference();
			LevelText = new inkTextWidgetReference();
			DEV_notYetImplemented = new inkWidgetReference();
			AnimProxies = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
