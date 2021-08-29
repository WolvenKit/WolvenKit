using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WidgetAnimationManager : IScriptable
	{
		private CArray<SWidgetAnimationData> _animations;

		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<SWidgetAnimationData> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}
	}
}
