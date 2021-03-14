using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileCollisionEvaluatorParams : IScriptable
	{
		private wCHandle<gameObject> _target;
		private CBool _isPiercableSurface;
		private CFloat _angle;
		private CUInt32 _numBounces;
		private Vector4 _position;
		private CName _projectilePenetration;
		private CBool _isTechPiercing;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isPiercableSurface")] 
		public CBool IsPiercableSurface
		{
			get
			{
				if (_isPiercableSurface == null)
				{
					_isPiercableSurface = (CBool) CR2WTypeManager.Create("Bool", "isPiercableSurface", cr2w, this);
				}
				return _isPiercableSurface;
			}
			set
			{
				if (_isPiercableSurface == value)
				{
					return;
				}
				_isPiercableSurface = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get
			{
				if (_angle == null)
				{
					_angle = (CFloat) CR2WTypeManager.Create("Float", "angle", cr2w, this);
				}
				return _angle;
			}
			set
			{
				if (_angle == value)
				{
					return;
				}
				_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numBounces")] 
		public CUInt32 NumBounces
		{
			get
			{
				if (_numBounces == null)
				{
					_numBounces = (CUInt32) CR2WTypeManager.Create("Uint32", "numBounces", cr2w, this);
				}
				return _numBounces;
			}
			set
			{
				if (_numBounces == value)
				{
					return;
				}
				_numBounces = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("projectilePenetration")] 
		public CName ProjectilePenetration
		{
			get
			{
				if (_projectilePenetration == null)
				{
					_projectilePenetration = (CName) CR2WTypeManager.Create("CName", "projectilePenetration", cr2w, this);
				}
				return _projectilePenetration;
			}
			set
			{
				if (_projectilePenetration == value)
				{
					return;
				}
				_projectilePenetration = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isTechPiercing")] 
		public CBool IsTechPiercing
		{
			get
			{
				if (_isTechPiercing == null)
				{
					_isTechPiercing = (CBool) CR2WTypeManager.Create("Bool", "isTechPiercing", cr2w, this);
				}
				return _isTechPiercing;
			}
			set
			{
				if (_isTechPiercing == value)
				{
					return;
				}
				_isTechPiercing = value;
				PropertySet(this);
			}
		}

		public gameprojectileCollisionEvaluatorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
