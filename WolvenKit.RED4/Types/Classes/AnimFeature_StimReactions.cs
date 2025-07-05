using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_StimReactions : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("reactionType")] 
		public CInt32 ReactionType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_StimReactions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
