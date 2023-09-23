using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestResume : ActionBool
	{
		[Ordinal(38)] 
		[RED("pauseTime")] 
		public CFloat PauseTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public QuestResume()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
