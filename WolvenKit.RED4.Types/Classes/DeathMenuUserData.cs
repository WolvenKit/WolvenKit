using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathMenuUserData : IScriptable
	{
		private CBool _playInitAnimation;

		[Ordinal(0)] 
		[RED("playInitAnimation")] 
		public CBool PlayInitAnimation
		{
			get => GetProperty(ref _playInitAnimation);
			set => SetProperty(ref _playInitAnimation, value);
		}
	}
}
