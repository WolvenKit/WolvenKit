using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_FacialReaction : animAnimFeature
	{
		private CInt32 _category;
		private CInt32 _idle;

		[Ordinal(0)] 
		[RED("category")] 
		public CInt32 Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(1)] 
		[RED("idle")] 
		public CInt32 Idle
		{
			get => GetProperty(ref _idle);
			set => SetProperty(ref _idle, value);
		}
	}
}
