using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseSubtitleLineLogicController : inkWidgetLogicController
	{
		private CWeakHandle<inkWidget> _root;
		private CBool _isKiroshiEnabled;
		private CFloat _c_tier1_duration;
		private CFloat _c_tier2_duration;

		[Ordinal(1)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(2)] 
		[RED("isKiroshiEnabled")] 
		public CBool IsKiroshiEnabled
		{
			get => GetProperty(ref _isKiroshiEnabled);
			set => SetProperty(ref _isKiroshiEnabled, value);
		}

		[Ordinal(3)] 
		[RED("c_tier1_duration")] 
		public CFloat C_tier1_duration
		{
			get => GetProperty(ref _c_tier1_duration);
			set => SetProperty(ref _c_tier1_duration, value);
		}

		[Ordinal(4)] 
		[RED("c_tier2_duration")] 
		public CFloat C_tier2_duration
		{
			get => GetProperty(ref _c_tier2_duration);
			set => SetProperty(ref _c_tier2_duration, value);
		}

		public BaseSubtitleLineLogicController()
		{
			_c_tier1_duration = 0.500000F;
			_c_tier2_duration = 5.000000F;
		}
	}
}
