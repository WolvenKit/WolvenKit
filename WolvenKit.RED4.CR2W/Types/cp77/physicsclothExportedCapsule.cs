using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothExportedCapsule : CVariable
	{
		private Vector3 _p0;
		private Vector3 _p1;
		private CFloat _r0;
		private CFloat _r1;
		private CName _boneName;

		[Ordinal(0)] 
		[RED("p0")] 
		public Vector3 P0
		{
			get
			{
				if (_p0 == null)
				{
					_p0 = (Vector3) CR2WTypeManager.Create("Vector3", "p0", cr2w, this);
				}
				return _p0;
			}
			set
			{
				if (_p0 == value)
				{
					return;
				}
				_p0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("p1")] 
		public Vector3 P1
		{
			get
			{
				if (_p1 == null)
				{
					_p1 = (Vector3) CR2WTypeManager.Create("Vector3", "p1", cr2w, this);
				}
				return _p1;
			}
			set
			{
				if (_p1 == value)
				{
					return;
				}
				_p1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("r0")] 
		public CFloat R0
		{
			get
			{
				if (_r0 == null)
				{
					_r0 = (CFloat) CR2WTypeManager.Create("Float", "r0", cr2w, this);
				}
				return _r0;
			}
			set
			{
				if (_r0 == value)
				{
					return;
				}
				_r0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("r1")] 
		public CFloat R1
		{
			get
			{
				if (_r1 == null)
				{
					_r1 = (CFloat) CR2WTypeManager.Create("Float", "r1", cr2w, this);
				}
				return _r1;
			}
			set
			{
				if (_r1 == value)
				{
					return;
				}
				_r1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get
			{
				if (_boneName == null)
				{
					_boneName = (CName) CR2WTypeManager.Create("CName", "boneName", cr2w, this);
				}
				return _boneName;
			}
			set
			{
				if (_boneName == value)
				{
					return;
				}
				_boneName = value;
				PropertySet(this);
			}
		}

		public physicsclothExportedCapsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
