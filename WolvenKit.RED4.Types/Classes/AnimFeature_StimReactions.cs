using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_StimReactions : animAnimFeature
	{
		private CInt32 _reactionType;

		[Ordinal(0)] 
		[RED("reactionType")] 
		public CInt32 ReactionType
		{
			get => GetProperty(ref _reactionType);
			set => SetProperty(ref _reactionType, value);
		}
	}
}
