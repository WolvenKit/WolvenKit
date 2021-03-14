using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentDangleInfo : CVariable
	{
		private CFloat _dangleSegmentLenght;
		private CFloat _dangleVelocityDamping;
		private CFloat _dangleBendStiffness;
		private CFloat _dangleSegmentStiffness;
		private CFloat _dangleCollisionSphereRadius;

		[Ordinal(0)] 
		[RED("DangleSegmentLenght")] 
		public CFloat DangleSegmentLenght
		{
			get
			{
				if (_dangleSegmentLenght == null)
				{
					_dangleSegmentLenght = (CFloat) CR2WTypeManager.Create("Float", "DangleSegmentLenght", cr2w, this);
				}
				return _dangleSegmentLenght;
			}
			set
			{
				if (_dangleSegmentLenght == value)
				{
					return;
				}
				_dangleSegmentLenght = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("DangleVelocityDamping")] 
		public CFloat DangleVelocityDamping
		{
			get
			{
				if (_dangleVelocityDamping == null)
				{
					_dangleVelocityDamping = (CFloat) CR2WTypeManager.Create("Float", "DangleVelocityDamping", cr2w, this);
				}
				return _dangleVelocityDamping;
			}
			set
			{
				if (_dangleVelocityDamping == value)
				{
					return;
				}
				_dangleVelocityDamping = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("DangleBendStiffness")] 
		public CFloat DangleBendStiffness
		{
			get
			{
				if (_dangleBendStiffness == null)
				{
					_dangleBendStiffness = (CFloat) CR2WTypeManager.Create("Float", "DangleBendStiffness", cr2w, this);
				}
				return _dangleBendStiffness;
			}
			set
			{
				if (_dangleBendStiffness == value)
				{
					return;
				}
				_dangleBendStiffness = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("DangleSegmentStiffness")] 
		public CFloat DangleSegmentStiffness
		{
			get
			{
				if (_dangleSegmentStiffness == null)
				{
					_dangleSegmentStiffness = (CFloat) CR2WTypeManager.Create("Float", "DangleSegmentStiffness", cr2w, this);
				}
				return _dangleSegmentStiffness;
			}
			set
			{
				if (_dangleSegmentStiffness == value)
				{
					return;
				}
				_dangleSegmentStiffness = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("DangleCollisionSphereRadius")] 
		public CFloat DangleCollisionSphereRadius
		{
			get
			{
				if (_dangleCollisionSphereRadius == null)
				{
					_dangleCollisionSphereRadius = (CFloat) CR2WTypeManager.Create("Float", "DangleCollisionSphereRadius", cr2w, this);
				}
				return _dangleCollisionSphereRadius;
			}
			set
			{
				if (_dangleCollisionSphereRadius == value)
				{
					return;
				}
				_dangleCollisionSphereRadius = value;
				PropertySet(this);
			}
		}

		public entdismembermentDangleInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
