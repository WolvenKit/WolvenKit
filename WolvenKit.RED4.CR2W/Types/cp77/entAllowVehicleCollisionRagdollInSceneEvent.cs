using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAllowVehicleCollisionRagdollInSceneEvent : redEvent
	{
		private CBool _allow;

		[Ordinal(0)] 
		[RED("allow")] 
		public CBool Allow
		{
			get
			{
				if (_allow == null)
				{
					_allow = (CBool) CR2WTypeManager.Create("Bool", "allow", cr2w, this);
				}
				return _allow;
			}
			set
			{
				if (_allow == value)
				{
					return;
				}
				_allow = value;
				PropertySet(this);
			}
		}

		public entAllowVehicleCollisionRagdollInSceneEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
