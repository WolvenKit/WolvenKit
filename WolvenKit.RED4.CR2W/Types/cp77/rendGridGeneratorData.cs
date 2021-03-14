using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendGridGeneratorData : CVariable
	{
		private Vector3 _startingPosition;
		private EulerAngles _rotation;
		private CFloat _xStep;
		private CFloat _yStep;
		private CUInt32 _numberOfXSteps;
		private CUInt32 _numberOfYSteps;
		private CFloat _orbitDistance;
		private CFloat _zoom;

		[Ordinal(0)] 
		[RED("startingPosition")] 
		public Vector3 StartingPosition
		{
			get
			{
				if (_startingPosition == null)
				{
					_startingPosition = (Vector3) CR2WTypeManager.Create("Vector3", "startingPosition", cr2w, this);
				}
				return _startingPosition;
			}
			set
			{
				if (_startingPosition == value)
				{
					return;
				}
				_startingPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public EulerAngles Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("xStep")] 
		public CFloat XStep
		{
			get
			{
				if (_xStep == null)
				{
					_xStep = (CFloat) CR2WTypeManager.Create("Float", "xStep", cr2w, this);
				}
				return _xStep;
			}
			set
			{
				if (_xStep == value)
				{
					return;
				}
				_xStep = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("yStep")] 
		public CFloat YStep
		{
			get
			{
				if (_yStep == null)
				{
					_yStep = (CFloat) CR2WTypeManager.Create("Float", "yStep", cr2w, this);
				}
				return _yStep;
			}
			set
			{
				if (_yStep == value)
				{
					return;
				}
				_yStep = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("numberOfXSteps")] 
		public CUInt32 NumberOfXSteps
		{
			get
			{
				if (_numberOfXSteps == null)
				{
					_numberOfXSteps = (CUInt32) CR2WTypeManager.Create("Uint32", "numberOfXSteps", cr2w, this);
				}
				return _numberOfXSteps;
			}
			set
			{
				if (_numberOfXSteps == value)
				{
					return;
				}
				_numberOfXSteps = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numberOfYSteps")] 
		public CUInt32 NumberOfYSteps
		{
			get
			{
				if (_numberOfYSteps == null)
				{
					_numberOfYSteps = (CUInt32) CR2WTypeManager.Create("Uint32", "numberOfYSteps", cr2w, this);
				}
				return _numberOfYSteps;
			}
			set
			{
				if (_numberOfYSteps == value)
				{
					return;
				}
				_numberOfYSteps = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("orbitDistance")] 
		public CFloat OrbitDistance
		{
			get
			{
				if (_orbitDistance == null)
				{
					_orbitDistance = (CFloat) CR2WTypeManager.Create("Float", "orbitDistance", cr2w, this);
				}
				return _orbitDistance;
			}
			set
			{
				if (_orbitDistance == value)
				{
					return;
				}
				_orbitDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get
			{
				if (_zoom == null)
				{
					_zoom = (CFloat) CR2WTypeManager.Create("Float", "zoom", cr2w, this);
				}
				return _zoom;
			}
			set
			{
				if (_zoom == value)
				{
					return;
				}
				_zoom = value;
				PropertySet(this);
			}
		}

		public rendGridGeneratorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
