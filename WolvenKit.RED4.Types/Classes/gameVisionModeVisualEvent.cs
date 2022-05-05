using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionModeVisualEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("group")] 
		public TweakDBID Group
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("changedModule")] 
		public CName ChangedModule
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CBool Activated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("meshComponentName")] 
		public CName MeshComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameVisionModeType> Type
		{
			get => GetPropertyValue<CEnum<gameVisionModeType>>();
			set => SetPropertyValue<CEnum<gameVisionModeType>>(value);
		}

		public gameVisionModeVisualEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
