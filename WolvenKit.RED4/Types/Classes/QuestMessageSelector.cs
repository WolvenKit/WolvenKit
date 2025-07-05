using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestMessageSelector : ScreenMessageSelector
	{
		[Ordinal(3)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public QuestMessageSelector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
