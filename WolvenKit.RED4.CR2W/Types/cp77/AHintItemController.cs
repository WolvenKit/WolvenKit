using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AHintItemController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _unavaliableText;
		private wCHandle<inkWidget> _root;

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
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public AHintItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
