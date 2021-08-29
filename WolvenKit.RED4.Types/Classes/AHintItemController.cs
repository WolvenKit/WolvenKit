using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AHintItemController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _unavaliableText;
		private CWeakHandle<inkWidget> _root;

		[Ordinal(1)] 
		[RED("Icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(2)] 
		[RED("UnavaliableText")] 
		public inkTextWidgetReference UnavaliableText
		{
			get => GetProperty(ref _unavaliableText);
			set => SetProperty(ref _unavaliableText, value);
		}

		[Ordinal(3)] 
		[RED("Root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}
	}
}
