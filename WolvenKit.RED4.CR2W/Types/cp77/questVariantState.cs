using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVariantState : CVariable
	{
		private CName _name;
		private CBool _show;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get
			{
				if (_show == null)
				{
					_show = (CBool) CR2WTypeManager.Create("Bool", "show", cr2w, this);
				}
				return _show;
			}
			set
			{
				if (_show == value)
				{
					return;
				}
				_show = value;
				PropertySet(this);
			}
		}

		public questVariantState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
