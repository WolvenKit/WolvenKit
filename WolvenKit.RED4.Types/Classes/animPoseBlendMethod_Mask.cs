using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseBlendMethod_Mask : animIPoseBlendMethod
	{
		private CName _maskName;

		[Ordinal(0)] 
		[RED("maskName")] 
		public CName MaskName
		{
			get => GetProperty(ref _maskName);
			set => SetProperty(ref _maskName, value);
		}
	}
}
