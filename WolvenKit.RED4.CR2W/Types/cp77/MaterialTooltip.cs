using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaterialTooltip : AGenericTooltipController
	{
		private inkWidgetReference _titleWrapper;
		private inkWidgetReference _descriptionWrapper;
		private inkWidgetReference _descriptionLine;
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _basePrice;
		private inkTextWidgetReference _price;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(2)] 
		[RED("titleWrapper")] 
		public inkWidgetReference TitleWrapper
		{
			get => GetProperty(ref _titleWrapper);
			set => SetProperty(ref _titleWrapper, value);
		}

		[Ordinal(3)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetProperty(ref _descriptionWrapper);
			set => SetProperty(ref _descriptionWrapper, value);
		}

		[Ordinal(4)] 
		[RED("descriptionLine")] 
		public inkWidgetReference DescriptionLine
		{
			get => GetProperty(ref _descriptionLine);
			set => SetProperty(ref _descriptionLine, value);
		}

		[Ordinal(5)] 
		[RED("Title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(6)] 
		[RED("BasePrice")] 
		public inkTextWidgetReference BasePrice
		{
			get => GetProperty(ref _basePrice);
			set => SetProperty(ref _basePrice, value);
		}

		[Ordinal(7)] 
		[RED("Price")] 
		public inkTextWidgetReference Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}

		[Ordinal(8)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public MaterialTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
