using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsUserEnteredCoverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("actionsPoints")] 
		public CArray<WorldTransform> ActionsPoints
		{
			get => GetPropertyValue<CArray<WorldTransform>>();
			set => SetPropertyValue<CArray<WorldTransform>>(value);
		}

		public gameeventsUserEnteredCoverEvent()
		{
			ActionsPoints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
