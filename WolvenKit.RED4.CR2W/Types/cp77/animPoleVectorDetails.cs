using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoleVectorDetails : CVariable
	{
		private animTransformIndex _targetBone;
		private Vector3 _positionOffset;

		[Ordinal(0)] 
		[RED("targetBone")] 
		public animTransformIndex TargetBone
		{
			get
			{
				if (_targetBone == null)
				{
					_targetBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "targetBone", cr2w, this);
				}
				return _targetBone;
			}
			set
			{
				if (_targetBone == value)
				{
					return;
				}
				_targetBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("positionOffset")] 
		public Vector3 PositionOffset
		{
			get
			{
				if (_positionOffset == null)
				{
					_positionOffset = (Vector3) CR2WTypeManager.Create("Vector3", "positionOffset", cr2w, this);
				}
				return _positionOffset;
			}
			set
			{
				if (_positionOffset == value)
				{
					return;
				}
				_positionOffset = value;
				PropertySet(this);
			}
		}

		public animPoleVectorDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
