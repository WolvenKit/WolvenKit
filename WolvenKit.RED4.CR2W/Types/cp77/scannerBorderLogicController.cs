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
			get
			{
				if (_braindanceSetVisible == null)
				{
					_braindanceSetVisible = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "braindanceSetVisible", cr2w, this);
				}
				return _braindanceSetVisible;
			}
			set
			{
				if (_braindanceSetVisible == value)
				{
					return;
				}
				_braindanceSetVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("braindanceSetHidden")] 
		public CArray<inkWidgetReference> BraindanceSetHidden
		{
			get
			{
				if (_braindanceSetHidden == null)
				{
					_braindanceSetHidden = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "braindanceSetHidden", cr2w, this);
				}
				return _braindanceSetHidden;
			}
			set
			{
				if (_braindanceSetHidden == value)
				{
					return;
				}
				_braindanceSetHidden = value;
				PropertySet(this);
			}
		}

		public scannerBorderLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
