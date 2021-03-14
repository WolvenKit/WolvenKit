using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystemSetBackpackFilter : gameScriptableSystemRequest
	{
		private CInt32 _filterMode;

		[Ordinal(0)] 
		[RED("filterMode")] 
		public CInt32 FilterMode
		{
			get
			{
				if (_filterMode == null)
				{
					_filterMode = (CInt32) CR2WTypeManager.Create("Int32", "filterMode", cr2w, this);
				}
				return _filterMode;
			}
			set
			{
				if (_filterMode == value)
				{
					return;
				}
				_filterMode = value;
				PropertySet(this);
			}
		}

		public UIScriptableSystemSetBackpackFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
