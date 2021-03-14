using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_WeaponUser : animAnimFeature
	{
		private Vector4 _ikLeftHandLocalPosition;
		private Vector4 _ikRightHandLocalPosition;

		[Ordinal(0)] 
		[RED("ikLeftHandLocalPosition")] 
		public Vector4 IkLeftHandLocalPosition
		{
			get
			{
				if (_ikLeftHandLocalPosition == null)
				{
					_ikLeftHandLocalPosition = (Vector4) CR2WTypeManager.Create("Vector4", "ikLeftHandLocalPosition", cr2w, this);
				}
				return _ikLeftHandLocalPosition;
			}
			set
			{
				if (_ikLeftHandLocalPosition == value)
				{
					return;
				}
				_ikLeftHandLocalPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ikRightHandLocalPosition")] 
		public Vector4 IkRightHandLocalPosition
		{
			get
			{
				if (_ikRightHandLocalPosition == null)
				{
					_ikRightHandLocalPosition = (Vector4) CR2WTypeManager.Create("Vector4", "ikRightHandLocalPosition", cr2w, this);
				}
				return _ikRightHandLocalPosition;
			}
			set
			{
				if (_ikRightHandLocalPosition == value)
				{
					return;
				}
				_ikRightHandLocalPosition = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_WeaponUser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
