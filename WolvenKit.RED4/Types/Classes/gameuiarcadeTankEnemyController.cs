using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeTankEnemyController : gameuiarcadeTankDestroyableObjectController
	{
		[Ordinal(3)] 
		[RED("headParent")] 
		public inkWidgetReference HeadParent
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("head")] 
		public inkWidgetReference Head
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeTankEnemyController()
		{
			HeadParent = new inkWidgetReference();
			Head = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
