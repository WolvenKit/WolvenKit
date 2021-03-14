using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuItemDimRequest : redEvent
	{
		private CBool _dim;

		[Ordinal(0)] 
		[RED("dim")] 
		public CBool Dim
		{
			get
			{
				if (_dim == null)
				{
					_dim = (CBool) CR2WTypeManager.Create("Bool", "dim", cr2w, this);
				}
				return _dim;
			}
			set
			{
				if (_dim == value)
				{
					return;
				}
				_dim = value;
				PropertySet(this);
			}
		}

		public MenuItemDimRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
