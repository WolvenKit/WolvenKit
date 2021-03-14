using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuDataBuilder : IScriptable
	{
		private CArray<MenuData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CArray<MenuData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<MenuData>) CR2WTypeManager.Create("array:MenuData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public MenuDataBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
