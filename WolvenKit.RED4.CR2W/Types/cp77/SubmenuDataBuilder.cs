using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubmenuDataBuilder : IScriptable
	{
		private CHandle<MenuDataBuilder> _menuBuilder;
		private CInt32 _menuDataIndex;

		[Ordinal(0)] 
		[RED("menuBuilder")] 
		public CHandle<MenuDataBuilder> MenuBuilder
		{
			get
			{
				if (_menuBuilder == null)
				{
					_menuBuilder = (CHandle<MenuDataBuilder>) CR2WTypeManager.Create("handle:MenuDataBuilder", "menuBuilder", cr2w, this);
				}
				return _menuBuilder;
			}
			set
			{
				if (_menuBuilder == value)
				{
					return;
				}
				_menuBuilder = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("menuDataIndex")] 
		public CInt32 MenuDataIndex
		{
			get
			{
				if (_menuDataIndex == null)
				{
					_menuDataIndex = (CInt32) CR2WTypeManager.Create("Int32", "menuDataIndex", cr2w, this);
				}
				return _menuDataIndex;
			}
			set
			{
				if (_menuDataIndex == value)
				{
					return;
				}
				_menuDataIndex = value;
				PropertySet(this);
			}
		}

		public SubmenuDataBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
