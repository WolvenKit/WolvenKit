using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshCrosshairEvent : redEvent
	{
		private CBool _force;

		[Ordinal(0)] 
		[RED("force")] 
		public CBool Force
		{
			get
			{
				if (_force == null)
				{
					_force = (CBool) CR2WTypeManager.Create("Bool", "force", cr2w, this);
				}
				return _force;
			}
			set
			{
				if (_force == value)
				{
					return;
				}
				_force = value;
				PropertySet(this);
			}
		}

		public RefreshCrosshairEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
