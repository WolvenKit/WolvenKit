using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animBoneTraceCondition : ISerializable
	{
		private CInt16 _boneIndex;
		private CBool _traceByRotation;
		private CFloat _rotationAngleTolerance;
		private CBool _traceByTranslation;
		private CFloat _translationTolerance;

		[Ordinal(0)] 
		[RED("boneIndex")] 
		public CInt16 BoneIndex
		{
			get
			{
				if (_boneIndex == null)
				{
					_boneIndex = (CInt16) CR2WTypeManager.Create("Int16", "boneIndex", cr2w, this);
				}
				return _boneIndex;
			}
			set
			{
				if (_boneIndex == value)
				{
					return;
				}
				_boneIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("traceByRotation")] 
		public CBool TraceByRotation
		{
			get
			{
				if (_traceByRotation == null)
				{
					_traceByRotation = (CBool) CR2WTypeManager.Create("Bool", "traceByRotation", cr2w, this);
				}
				return _traceByRotation;
			}
			set
			{
				if (_traceByRotation == value)
				{
					return;
				}
				_traceByRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rotationAngleTolerance")] 
		public CFloat RotationAngleTolerance
		{
			get
			{
				if (_rotationAngleTolerance == null)
				{
					_rotationAngleTolerance = (CFloat) CR2WTypeManager.Create("Float", "rotationAngleTolerance", cr2w, this);
				}
				return _rotationAngleTolerance;
			}
			set
			{
				if (_rotationAngleTolerance == value)
				{
					return;
				}
				_rotationAngleTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("traceByTranslation")] 
		public CBool TraceByTranslation
		{
			get
			{
				if (_traceByTranslation == null)
				{
					_traceByTranslation = (CBool) CR2WTypeManager.Create("Bool", "traceByTranslation", cr2w, this);
				}
				return _traceByTranslation;
			}
			set
			{
				if (_traceByTranslation == value)
				{
					return;
				}
				_traceByTranslation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("translationTolerance")] 
		public CFloat TranslationTolerance
		{
			get
			{
				if (_translationTolerance == null)
				{
					_translationTolerance = (CFloat) CR2WTypeManager.Create("Float", "translationTolerance", cr2w, this);
				}
				return _translationTolerance;
			}
			set
			{
				if (_translationTolerance == value)
				{
					return;
				}
				_translationTolerance = value;
				PropertySet(this);
			}
		}

		public animBoneTraceCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
