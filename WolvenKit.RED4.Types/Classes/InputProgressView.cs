using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InputProgressView : inkWidgetLogicController
	{
		private CWeakHandle<inkImageWidget> _targetImage;
		private CInt32 _progressPercent;
		private CString _partName;

		[Ordinal(1)] 
		[RED("TargetImage")] 
		public CWeakHandle<inkImageWidget> TargetImage
		{
			get => GetProperty(ref _targetImage);
			set => SetProperty(ref _targetImage, value);
		}

		[Ordinal(2)] 
		[RED("ProgressPercent")] 
		public CInt32 ProgressPercent
		{
			get => GetProperty(ref _progressPercent);
			set => SetProperty(ref _progressPercent, value);
		}

		[Ordinal(3)] 
		[RED("PartName")] 
		public CString PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}
	}
}
