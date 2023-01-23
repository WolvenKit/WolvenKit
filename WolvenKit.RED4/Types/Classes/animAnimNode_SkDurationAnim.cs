using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkDurationAnim : animAnimNode_SkAnim
	{
		[Ordinal(30)] 
		[RED("Duration")] 
		public animFloatLink Duration
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_SkDurationAnim()
		{
			Duration = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
