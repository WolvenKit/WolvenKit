using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnscreenDisplayManager : inkWidgetLogicController
	{
		private inkTextWidgetReference _contentText;

		[Ordinal(1)] 
		[RED("contentText")] 
		public inkTextWidgetReference ContentText
		{
			get => GetProperty(ref _contentText);
			set => SetProperty(ref _contentText, value);
		}

		public OnscreenDisplayManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
