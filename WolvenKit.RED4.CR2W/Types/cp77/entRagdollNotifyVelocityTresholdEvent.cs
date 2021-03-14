using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollNotifyVelocityTresholdEvent : redEvent
	{
		private Vector4 _velocity;

		[Ordinal(0)] 
		[RED("velocity")] 
		public Vector4 Velocity
		{
			get
			{
				if (_velocity == null)
				{
					_velocity = (Vector4) CR2WTypeManager.Create("Vector4", "velocity", cr2w, this);
				}
				return _velocity;
			}
			set
			{
				if (_velocity == value)
				{
					return;
				}
				_velocity = value;
				PropertySet(this);
			}
		}

		public entRagdollNotifyVelocityTresholdEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
