using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_ChestPress : animAnimFeature
	{
		private CBool _lifting;
		private CBool _kill;

		[Ordinal(0)] 
		[RED("lifting")] 
		public CBool Lifting
		{
			get => GetProperty(ref _lifting);
			set => SetProperty(ref _lifting, value);
		}

		[Ordinal(1)] 
		[RED("kill")] 
		public CBool Kill
		{
			get => GetProperty(ref _kill);
			set => SetProperty(ref _kill, value);
		}
	}
}
