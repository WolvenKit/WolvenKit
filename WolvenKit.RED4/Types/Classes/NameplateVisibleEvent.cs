using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NameplateVisibleEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isNameplateVisible")] 
		public CBool IsNameplateVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public NameplateVisibleEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
