using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerFacingBeam : IParticleDrawer
	{
		private CFloat _texturesPerUnit;
		private CBool _dynamicTexCoords;
		private CFloat _transparencyOffset;
		private CFloat _transparencyLength;
		private CUInt32 _numSegments;
		private Vector4 _sourceTangent;
		private Vector4 _targetTangent;
		private Vector3 _debugTargetTranslation;

		[Ordinal(1)] 
		[RED("texturesPerUnit")] 
		public CFloat TexturesPerUnit
		{
			get
			{
				if (_texturesPerUnit == null)
				{
					_texturesPerUnit = (CFloat) CR2WTypeManager.Create("Float", "texturesPerUnit", cr2w, this);
				}
				return _texturesPerUnit;
			}
			set
			{
				if (_texturesPerUnit == value)
				{
					return;
				}
				_texturesPerUnit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("dynamicTexCoords")] 
		public CBool DynamicTexCoords
		{
			get
			{
				if (_dynamicTexCoords == null)
				{
					_dynamicTexCoords = (CBool) CR2WTypeManager.Create("Bool", "dynamicTexCoords", cr2w, this);
				}
				return _dynamicTexCoords;
			}
			set
			{
				if (_dynamicTexCoords == value)
				{
					return;
				}
				_dynamicTexCoords = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transparencyOffset")] 
		public CFloat TransparencyOffset
		{
			get
			{
				if (_transparencyOffset == null)
				{
					_transparencyOffset = (CFloat) CR2WTypeManager.Create("Float", "transparencyOffset", cr2w, this);
				}
				return _transparencyOffset;
			}
			set
			{
				if (_transparencyOffset == value)
				{
					return;
				}
				_transparencyOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("transparencyLength")] 
		public CFloat TransparencyLength
		{
			get
			{
				if (_transparencyLength == null)
				{
					_transparencyLength = (CFloat) CR2WTypeManager.Create("Float", "transparencyLength", cr2w, this);
				}
				return _transparencyLength;
			}
			set
			{
				if (_transparencyLength == value)
				{
					return;
				}
				_transparencyLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numSegments")] 
		public CUInt32 NumSegments
		{
			get
			{
				if (_numSegments == null)
				{
					_numSegments = (CUInt32) CR2WTypeManager.Create("Uint32", "numSegments", cr2w, this);
				}
				return _numSegments;
			}
			set
			{
				if (_numSegments == value)
				{
					return;
				}
				_numSegments = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sourceTangent")] 
		public Vector4 SourceTangent
		{
			get
			{
				if (_sourceTangent == null)
				{
					_sourceTangent = (Vector4) CR2WTypeManager.Create("Vector4", "sourceTangent", cr2w, this);
				}
				return _sourceTangent;
			}
			set
			{
				if (_sourceTangent == value)
				{
					return;
				}
				_sourceTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("targetTangent")] 
		public Vector4 TargetTangent
		{
			get
			{
				if (_targetTangent == null)
				{
					_targetTangent = (Vector4) CR2WTypeManager.Create("Vector4", "targetTangent", cr2w, this);
				}
				return _targetTangent;
			}
			set
			{
				if (_targetTangent == value)
				{
					return;
				}
				_targetTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("debugTargetTranslation")] 
		public Vector3 DebugTargetTranslation
		{
			get
			{
				if (_debugTargetTranslation == null)
				{
					_debugTargetTranslation = (Vector3) CR2WTypeManager.Create("Vector3", "debugTargetTranslation", cr2w, this);
				}
				return _debugTargetTranslation;
			}
			set
			{
				if (_debugTargetTranslation == value)
				{
					return;
				}
				_debugTargetTranslation = value;
				PropertySet(this);
			}
		}

		public CParticleDrawerFacingBeam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
