using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectRootEntry : CVariable
	{
		private Vector3 _relativePosition;
		private Quaternion _relativeRotation;

		[Ordinal(0)] 
		[RED("relativePosition")] 
		public Vector3 RelativePosition
		{
			get
			{
				if (_relativePosition == null)
				{
					_relativePosition = (Vector3) CR2WTypeManager.Create("Vector3", "relativePosition", cr2w, this);
				}
				return _relativePosition;
			}
			set
			{
				if (_relativePosition == value)
				{
					return;
				}
				_relativePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("relativeRotation")] 
		public Quaternion RelativeRotation
		{
			get
			{
				if (_relativeRotation == null)
				{
					_relativeRotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "relativeRotation", cr2w, this);
				}
				return _relativeRotation;
			}
			set
			{
				if (_relativeRotation == value)
				{
					return;
				}
				_relativeRotation = value;
				PropertySet(this);
			}
		}

		public effectRootEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
