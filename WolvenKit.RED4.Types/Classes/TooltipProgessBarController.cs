using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TooltipProgessBarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("progressFill")] 
		public inkWidgetReference ProgressFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("hintHolder")] 
		public inkWidgetReference HintHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("progressHolder")] 
		public inkWidgetReference ProgressHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("postprogressHolder")] 
		public inkWidgetReference PostprogressHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("hintTextHolder")] 
		public inkCompoundWidgetReference HintTextHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(7)] 
		[RED("postprogressText")] 
		public inkTextWidgetReference PostprogressText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isCrafted")] 
		public CBool IsCrafted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TooltipProgessBarController()
		{
			ProgressFill = new();
			HintHolder = new();
			ProgressHolder = new();
			PostprogressHolder = new();
			HintTextHolder = new();
			LibraryPath = new() { WidgetLibrary = new() };
			PostprogressText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
