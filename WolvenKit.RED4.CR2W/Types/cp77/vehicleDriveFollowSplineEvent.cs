using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveFollowSplineEvent : redEvent
	{
		private NodeRef _splineRef;
		private CBool _backwards;
		private CBool _reverseSpline;

		[Ordinal(0)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get
			{
				if (_splineRef == null)
				{
					_splineRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineRef", cr2w, this);
				}
				return _splineRef;
			}
			set
			{
				if (_splineRef == value)
				{
					return;
				}
				_splineRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("backwards")] 
		public CBool Backwards
		{
			get
			{
				if (_backwards == null)
				{
					_backwards = (CBool) CR2WTypeManager.Create("Bool", "backwards", cr2w, this);
				}
				return _backwards;
			}
			set
			{
				if (_backwards == value)
				{
					return;
				}
				_backwards = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get
			{
				if (_reverseSpline == null)
				{
					_reverseSpline = (CBool) CR2WTypeManager.Create("Bool", "reverseSpline", cr2w, this);
				}
				return _reverseSpline;
			}
			set
			{
				if (_reverseSpline == value)
				{
					return;
				}
				_reverseSpline = value;
				PropertySet(this);
			}
		}

		public vehicleDriveFollowSplineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
