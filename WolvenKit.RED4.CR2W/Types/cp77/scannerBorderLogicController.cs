using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scannerBorderLogicController : inkWidgetLogicController
	{
		private CArray<inkWidgetReference> _braindanceSetVisible;
		private CArray<inkWidgetReference> _braindanceSetHidden;

		[Ordinal(1)] 
		[RED("braindanceSetVisible")] 
		public CArray<inkWidgetReference> BraindanceSetVisible
		{
			get => GetProperty(ref _braindanceSetVisible);
			set => SetProperty(ref _braindanceSetVisible, value);
		}

		[Ordinal(2)] 
		[RED("braindanceSetHidden")] 
		public CArray<inkWidgetReference> BraindanceSetHidden
		{
			get => GetProperty(ref _braindanceSetHidden);
			set => SetProperty(ref _braindanceSetHidden, value);
		}

		public scannerBorderLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
