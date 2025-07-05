using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PaginationNumberController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("numberText")] 
		public inkTextWidgetReference NumberText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("line")] 
		public inkWidgetReference Line
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("pageNumber")] 
		public CInt32 PageNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("isActiveNumber")] 
		public CBool IsActiveNumber
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PaginationNumberController()
		{
			NumberText = new inkTextWidgetReference();
			Line = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
