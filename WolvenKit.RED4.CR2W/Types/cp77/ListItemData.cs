using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ListItemData : IScriptable
	{
		private CString _label;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get
			{
				if (_label == null)
				{
					_label = (CString) CR2WTypeManager.Create("String", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		public ListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
