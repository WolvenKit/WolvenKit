using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRotatingMeshNode : worldMeshNode
	{
		private CEnum<worldRotatingMeshNodeAxis> _rotationAxis;
		private CFloat _fullRotationTime;
		private CBool _reverseDirection;

		[Ordinal(15)] 
		[RED("rotationAxis")] 
		public CEnum<worldRotatingMeshNodeAxis> RotationAxis
		{
			get
			{
				if (_rotationAxis == null)
				{
					_rotationAxis = (CEnum<worldRotatingMeshNodeAxis>) CR2WTypeManager.Create("worldRotatingMeshNodeAxis", "rotationAxis", cr2w, this);
				}
				return _rotationAxis;
			}
			set
			{
				if (_rotationAxis == value)
				{
					return;
				}
				_rotationAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("fullRotationTime")] 
		public CFloat FullRotationTime
		{
			get
			{
				if (_fullRotationTime == null)
				{
					_fullRotationTime = (CFloat) CR2WTypeManager.Create("Float", "fullRotationTime", cr2w, this);
				}
				return _fullRotationTime;
			}
			set
			{
				if (_fullRotationTime == value)
				{
					return;
				}
				_fullRotationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("reverseDirection")] 
		public CBool ReverseDirection
		{
			get
			{
				if (_reverseDirection == null)
				{
					_reverseDirection = (CBool) CR2WTypeManager.Create("Bool", "reverseDirection", cr2w, this);
				}
				return _reverseDirection;
			}
			set
			{
				if (_reverseDirection == value)
				{
					return;
				}
				_reverseDirection = value;
				PropertySet(this);
			}
		}

		public worldRotatingMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
