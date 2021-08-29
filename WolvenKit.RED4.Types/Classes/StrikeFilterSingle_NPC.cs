using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StrikeFilterSingle_NPC : gameEffectObjectSingleFilter_Scripted
	{
		private CBool _onlyAlive;

		[Ordinal(0)] 
		[RED("onlyAlive")] 
		public CBool OnlyAlive
		{
			get => GetProperty(ref _onlyAlive);
			set => SetProperty(ref _onlyAlive, value);
		}
	}
}
