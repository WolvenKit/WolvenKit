using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterPlatformImageDetail : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("platformImage")] 
		public inkWidgetReference PlatformImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeShooterPlatformImageDetail()
		{
			PlatformImage = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
