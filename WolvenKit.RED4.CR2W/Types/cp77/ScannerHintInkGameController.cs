using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerHintInkGameController : gameuiWidgetGameController
	{
		private wCHandle<inkTextWidget> _messegeWidget;
		private wCHandle<inkWidget> _root;
		private inkImageWidgetReference _iconWidget;

		[Ordinal(2)] 
		[RED("messegeWidget")] 
		public wCHandle<inkTextWidget> MessegeWidget
		{
			get => GetProperty(ref _messegeWidget);
			set => SetProperty(ref _messegeWidget, value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(4)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetProperty(ref _iconWidget);
			set => SetProperty(ref _iconWidget, value);
		}

		public ScannerHintInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
