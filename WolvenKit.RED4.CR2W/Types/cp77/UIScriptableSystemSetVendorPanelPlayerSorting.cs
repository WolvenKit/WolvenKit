using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystemSetVendorPanelPlayerSorting : gameScriptableSystemRequest
	{
		private CInt32 _sortMode;

		[Ordinal(0)] 
		[RED("sortMode")] 
		public CInt32 SortMode
		{
			get
			{
				if (_sortMode == null)
				{
					_sortMode = (CInt32) CR2WTypeManager.Create("Int32", "sortMode", cr2w, this);
				}
				return _sortMode;
			}
			set
			{
				if (_sortMode == value)
				{
					return;
				}
				_sortMode = value;
				PropertySet(this);
			}
		}

		public UIScriptableSystemSetVendorPanelPlayerSorting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
