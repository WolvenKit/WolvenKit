using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentCullObject : CVariable
	{
		private Plane _plane;
		private Plane _plane1;
		private Vector3 _capsulePointA;
		private Vector3 _capsulePointB;
		private CFloat _capsuleRadius;
		private CName _nearestAnimBoneName;
		private CInt16 _nearestAnimIndex;
		private CUInt16 _ragdollBodyIndex;

		[Ordinal(0)] 
		[RED("Plane")] 
		public Plane Plane
		{
			get
			{
				if (_plane == null)
				{
					_plane = (Plane) CR2WTypeManager.Create("Plane", "Plane", cr2w, this);
				}
				return _plane;
			}
			set
			{
				if (_plane == value)
				{
					return;
				}
				_plane = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Plane1")] 
		public Plane Plane1
		{
			get
			{
				if (_plane1 == null)
				{
					_plane1 = (Plane) CR2WTypeManager.Create("Plane", "Plane1", cr2w, this);
				}
				return _plane1;
			}
			set
			{
				if (_plane1 == value)
				{
					return;
				}
				_plane1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("CapsulePointA")] 
		public Vector3 CapsulePointA
		{
			get
			{
				if (_capsulePointA == null)
				{
					_capsulePointA = (Vector3) CR2WTypeManager.Create("Vector3", "CapsulePointA", cr2w, this);
				}
				return _capsulePointA;
			}
			set
			{
				if (_capsulePointA == value)
				{
					return;
				}
				_capsulePointA = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("CapsulePointB")] 
		public Vector3 CapsulePointB
		{
			get
			{
				if (_capsulePointB == null)
				{
					_capsulePointB = (Vector3) CR2WTypeManager.Create("Vector3", "CapsulePointB", cr2w, this);
				}
				return _capsulePointB;
			}
			set
			{
				if (_capsulePointB == value)
				{
					return;
				}
				_capsulePointB = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("CapsuleRadius")] 
		public CFloat CapsuleRadius
		{
			get
			{
				if (_capsuleRadius == null)
				{
					_capsuleRadius = (CFloat) CR2WTypeManager.Create("Float", "CapsuleRadius", cr2w, this);
				}
				return _capsuleRadius;
			}
			set
			{
				if (_capsuleRadius == value)
				{
					return;
				}
				_capsuleRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("NearestAnimBoneName")] 
		public CName NearestAnimBoneName
		{
			get
			{
				if (_nearestAnimBoneName == null)
				{
					_nearestAnimBoneName = (CName) CR2WTypeManager.Create("CName", "NearestAnimBoneName", cr2w, this);
				}
				return _nearestAnimBoneName;
			}
			set
			{
				if (_nearestAnimBoneName == value)
				{
					return;
				}
				_nearestAnimBoneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("NearestAnimIndex")] 
		public CInt16 NearestAnimIndex
		{
			get
			{
				if (_nearestAnimIndex == null)
				{
					_nearestAnimIndex = (CInt16) CR2WTypeManager.Create("Int16", "NearestAnimIndex", cr2w, this);
				}
				return _nearestAnimIndex;
			}
			set
			{
				if (_nearestAnimIndex == value)
				{
					return;
				}
				_nearestAnimIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("RagdollBodyIndex")] 
		public CUInt16 RagdollBodyIndex
		{
			get
			{
				if (_ragdollBodyIndex == null)
				{
					_ragdollBodyIndex = (CUInt16) CR2WTypeManager.Create("Uint16", "RagdollBodyIndex", cr2w, this);
				}
				return _ragdollBodyIndex;
			}
			set
			{
				if (_ragdollBodyIndex == value)
				{
					return;
				}
				_ragdollBodyIndex = value;
				PropertySet(this);
			}
		}

		public entdismembermentCullObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
