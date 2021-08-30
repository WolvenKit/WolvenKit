using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_NewEffect_RicochetScan : gameEffectExecutor_NewEffect
	{
		private Vector4 _box;
		private CBool _isPreview;
		private CBool _onlyForPlayer;

		[Ordinal(5)] 
		[RED("box")] 
		public Vector4 Box
		{
			get => GetProperty(ref _box);
			set => SetProperty(ref _box, value);
		}

		[Ordinal(6)] 
		[RED("isPreview")] 
		public CBool IsPreview
		{
			get => GetProperty(ref _isPreview);
			set => SetProperty(ref _isPreview, value);
		}

		[Ordinal(7)] 
		[RED("onlyForPlayer")] 
		public CBool OnlyForPlayer
		{
			get => GetProperty(ref _onlyForPlayer);
			set => SetProperty(ref _onlyForPlayer, value);
		}

		public gameEffectExecutor_NewEffect_RicochetScan()
		{
			_onlyForPlayer = true;
		}
	}
}
