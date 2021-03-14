using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuProficiencyItemClicked : PerksMenuAttributeItemClicked
	{
		private CInt32 _index;

		[Ordinal(3)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		public PerksMenuProficiencyItemClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
