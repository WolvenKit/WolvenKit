using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsRemoveStatusEffect : gameeventsStatusEffectEvent
	{
		private CBool _isFinalRemoval;

		[Ordinal(2)] 
		[RED("isFinalRemoval")] 
		public CBool IsFinalRemoval
		{
			get => GetProperty(ref _isFinalRemoval);
			set => SetProperty(ref _isFinalRemoval, value);
		}
	}
}
