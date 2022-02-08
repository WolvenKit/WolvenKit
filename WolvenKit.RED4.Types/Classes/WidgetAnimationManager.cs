using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WidgetAnimationManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<SWidgetAnimationData> Animations
		{
			get => GetPropertyValue<CArray<SWidgetAnimationData>>();
			set => SetPropertyValue<CArray<SWidgetAnimationData>>(value);
		}

		public WidgetAnimationManager()
		{
			Animations = new();
		}
	}
}
