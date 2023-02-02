using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CameraSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CameraSetup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
