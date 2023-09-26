using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeTankBackgroundController : gameuiarcadeArcadeBackgroundController
	{
		[Ordinal(2)] 
		[RED("decorationSpawner")] 
		public inkWidgetReference DecorationSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeTankBackgroundController()
		{
			DecorationSpawner = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
