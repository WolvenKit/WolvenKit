using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InputProgressView : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("TargetImage")] 
		public CWeakHandle<inkImageWidget> TargetImage
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("ProgressPercent")] 
		public CInt32 ProgressPercent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("PartName")] 
		public CString PartName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public InputProgressView()
		{
			PartName = "icon_circle_anim_";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
