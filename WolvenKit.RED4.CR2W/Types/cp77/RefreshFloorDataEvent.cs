using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshFloorDataEvent : redEvent
	{
		private CBool _passToEntity;

		[Ordinal(0)] 
		[RED("passToEntity")] 
		public CBool PassToEntity
		{
			get
			{
				if (_passToEntity == null)
				{
					_passToEntity = (CBool) CR2WTypeManager.Create("Bool", "passToEntity", cr2w, this);
				}
				return _passToEntity;
			}
			set
			{
				if (_passToEntity == value)
				{
					return;
				}
				_passToEntity = value;
				PropertySet(this);
			}
		}

		public RefreshFloorDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
