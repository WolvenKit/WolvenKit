using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animPoseBlendMethod_Mask : animIPoseBlendMethod
	{
		[Ordinal(0)] 
		[RED("maskName")] 
		public CName MaskName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animPoseBlendMethod_Mask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
