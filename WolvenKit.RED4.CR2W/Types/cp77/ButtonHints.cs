using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ButtonHints : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _horizontalHolder;

		[Ordinal(1)] 
		[RED("horizontalHolder")] 
		public inkCompoundWidgetReference HorizontalHolder
		{
			get => GetProperty(ref _horizontalHolder);
			set => SetProperty(ref _horizontalHolder, value);
		}

		public ButtonHints(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
