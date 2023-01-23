using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CaptionImageIconsLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("LifeIcon")] 
		public inkImageWidgetReference LifeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("CheckIcon")] 
		public inkImageWidgetReference CheckIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("GenericIcon")] 
		public inkImageWidgetReference GenericIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("PayIcon")] 
		public inkImageWidgetReference PayIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("LifeHolder")] 
		public inkCompoundWidgetReference LifeHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("CheckHolder")] 
		public inkCompoundWidgetReference CheckHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("GenericHolder")] 
		public inkCompoundWidgetReference GenericHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("PayHolder")] 
		public inkCompoundWidgetReference PayHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("LifeDescriptionText")] 
		public inkTextWidgetReference LifeDescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("CheckText")] 
		public inkTextWidgetReference CheckText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("PayText")] 
		public inkTextWidgetReference PayText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("LifeBackground")] 
		public inkWidgetReference LifeBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("LifeBackgroundFail")] 
		public inkWidgetReference LifeBackgroundFail
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("CheckBackground")] 
		public inkWidgetReference CheckBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("CheckBackgroundFail")] 
		public inkWidgetReference CheckBackgroundFail
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("PayBackground")] 
		public inkWidgetReference PayBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("PayBackgroundFail")] 
		public inkWidgetReference PayBackgroundFail
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public CaptionImageIconsLogicController()
		{
			LifeIcon = new();
			CheckIcon = new();
			GenericIcon = new();
			PayIcon = new();
			LifeHolder = new();
			CheckHolder = new();
			GenericHolder = new();
			PayHolder = new();
			LifeDescriptionText = new();
			CheckText = new();
			PayText = new();
			LifeBackground = new();
			LifeBackgroundFail = new();
			CheckBackground = new();
			CheckBackgroundFail = new();
			PayBackground = new();
			PayBackgroundFail = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
