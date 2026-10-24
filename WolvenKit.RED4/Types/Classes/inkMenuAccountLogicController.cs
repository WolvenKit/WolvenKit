using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkMenuAccountLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("playerId")] 
		public inkTextWidgetReference PlayerId
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("changeAccountButtonRef")] 
		public inkWidgetReference ChangeAccountButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("inputDisplayControllerRef")] 
		public inkWidgetReference InputDisplayControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("changeAccountEnabled")] 
		public CBool ChangeAccountEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkMenuAccountLogicController()
		{
			PlayerId = new inkTextWidgetReference();
			ChangeAccountButtonRef = new inkWidgetReference();
			InputDisplayControllerRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
