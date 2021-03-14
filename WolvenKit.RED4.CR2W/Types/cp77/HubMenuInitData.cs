using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubMenuInitData : IScriptable
	{
		private CName _menuName;
		private CName _submenuName;
		private CHandle<IScriptable> _userData;

		[Ordinal(0)] 
		[RED("menuName")] 
		public CName MenuName
		{
			get
			{
				if (_menuName == null)
				{
					_menuName = (CName) CR2WTypeManager.Create("CName", "menuName", cr2w, this);
				}
				return _menuName;
			}
			set
			{
				if (_menuName == value)
				{
					return;
				}
				_menuName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("submenuName")] 
		public CName SubmenuName
		{
			get
			{
				if (_submenuName == null)
				{
					_submenuName = (CName) CR2WTypeManager.Create("CName", "submenuName", cr2w, this);
				}
				return _submenuName;
			}
			set
			{
				if (_submenuName == value)
				{
					return;
				}
				_submenuName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		public HubMenuInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
