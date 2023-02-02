using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsDeathParamsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("noAnimation")] 
		public CBool NoAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("noRagdoll")] 
		public CBool NoRagdoll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameeventsDeathParamsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
