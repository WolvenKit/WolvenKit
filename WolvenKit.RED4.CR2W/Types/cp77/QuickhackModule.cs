using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhackModule : HUDModule
	{
		private CBool _calculateClose;

		[Ordinal(3)] 
		[RED("calculateClose")] 
		public CBool CalculateClose
		{
			get
			{
				if (_calculateClose == null)
				{
					_calculateClose = (CBool) CR2WTypeManager.Create("Bool", "calculateClose", cr2w, this);
				}
				return _calculateClose;
			}
			set
			{
				if (_calculateClose == value)
				{
					return;
				}
				_calculateClose = value;
				PropertySet(this);
			}
		}

		public QuickhackModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
