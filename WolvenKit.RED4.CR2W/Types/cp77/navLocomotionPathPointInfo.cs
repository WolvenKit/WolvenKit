using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathPointInfo : CVariable
	{
		private navSerializableSplineProgression _point;
		private CUInt32 _userDataIndex;

		[Ordinal(0)] 
		[RED("point")] 
		public navSerializableSplineProgression Point
		{
			get
			{
				if (_point == null)
				{
					_point = (navSerializableSplineProgression) CR2WTypeManager.Create("navSerializableSplineProgression", "point", cr2w, this);
				}
				return _point;
			}
			set
			{
				if (_point == value)
				{
					return;
				}
				_point = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("userDataIndex")] 
		public CUInt32 UserDataIndex
		{
			get
			{
				if (_userDataIndex == null)
				{
					_userDataIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "userDataIndex", cr2w, this);
				}
				return _userDataIndex;
			}
			set
			{
				if (_userDataIndex == value)
				{
					return;
				}
				_userDataIndex = value;
				PropertySet(this);
			}
		}

		public navLocomotionPathPointInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
