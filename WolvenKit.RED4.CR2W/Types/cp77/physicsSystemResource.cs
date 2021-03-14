using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSystemResource : CResource
	{
		private CArray<CHandle<physicsSystemBody>> _bodies;
		private CArray<CHandle<physicsSystemJoint>> _joints;

		[Ordinal(1)] 
		[RED("bodies")] 
		public CArray<CHandle<physicsSystemBody>> Bodies
		{
			get
			{
				if (_bodies == null)
				{
					_bodies = (CArray<CHandle<physicsSystemBody>>) CR2WTypeManager.Create("array:handle:physicsSystemBody", "bodies", cr2w, this);
				}
				return _bodies;
			}
			set
			{
				if (_bodies == value)
				{
					return;
				}
				_bodies = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("joints")] 
		public CArray<CHandle<physicsSystemJoint>> Joints
		{
			get
			{
				if (_joints == null)
				{
					_joints = (CArray<CHandle<physicsSystemJoint>>) CR2WTypeManager.Create("array:handle:physicsSystemJoint", "joints", cr2w, this);
				}
				return _joints;
			}
			set
			{
				if (_joints == value)
				{
					return;
				}
				_joints = value;
				PropertySet(this);
			}
		}

		public physicsSystemResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
