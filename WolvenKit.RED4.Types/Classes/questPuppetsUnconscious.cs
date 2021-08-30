using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPuppetsUnconscious : questPuppetsEffector
	{
		private CBool _setUnconscious;

		[Ordinal(0)] 
		[RED("setUnconscious")] 
		public CBool SetUnconscious
		{
			get => GetProperty(ref _setUnconscious);
			set => SetProperty(ref _setUnconscious, value);
		}

		public questPuppetsUnconscious()
		{
			_setUnconscious = true;
		}
	}
}
