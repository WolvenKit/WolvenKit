using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpConveyorObject : gameObject
	{
		private CFloat _rotationLerpFactor;
		private CBool _ignoreZAxis;

		[Ordinal(40)] 
		[RED("rotationLerpFactor")] 
		public CFloat RotationLerpFactor
		{
			get
			{
				if (_rotationLerpFactor == null)
				{
					_rotationLerpFactor = (CFloat) CR2WTypeManager.Create("Float", "rotationLerpFactor", cr2w, this);
				}
				return _rotationLerpFactor;
			}
			set
			{
				if (_rotationLerpFactor == value)
				{
					return;
				}
				_rotationLerpFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("ignoreZAxis")] 
		public CBool IgnoreZAxis
		{
			get
			{
				if (_ignoreZAxis == null)
				{
					_ignoreZAxis = (CBool) CR2WTypeManager.Create("Bool", "ignoreZAxis", cr2w, this);
				}
				return _ignoreZAxis;
			}
			set
			{
				if (_ignoreZAxis == value)
				{
					return;
				}
				_ignoreZAxis = value;
				PropertySet(this);
			}
		}

		public cpConveyorObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
