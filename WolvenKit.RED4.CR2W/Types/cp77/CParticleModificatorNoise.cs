using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorNoise : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _amplitude;
		private CHandle<IEvaluatorVector> _offset;
		private CHandle<IEvaluatorVector> _frequency;
		private Vector3 _changeRate;
		private CBool _applyToPosition;
		private CBool _worldSpaceOffset;
		private CEnum<ENoiseType> _noiseType;

		[Ordinal(4)] 
		[RED("amplitude")] 
		public CHandle<IEvaluatorVector> Amplitude
		{
			get
			{
				if (_amplitude == null)
				{
					_amplitude = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "amplitude", cr2w, this);
				}
				return _amplitude;
			}
			set
			{
				if (_amplitude == value)
				{
					return;
				}
				_amplitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("offset")] 
		public CHandle<IEvaluatorVector> Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("frequency")] 
		public CHandle<IEvaluatorVector> Frequency
		{
			get
			{
				if (_frequency == null)
				{
					_frequency = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "frequency", cr2w, this);
				}
				return _frequency;
			}
			set
			{
				if (_frequency == value)
				{
					return;
				}
				_frequency = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("changeRate")] 
		public Vector3 ChangeRate
		{
			get
			{
				if (_changeRate == null)
				{
					_changeRate = (Vector3) CR2WTypeManager.Create("Vector3", "changeRate", cr2w, this);
				}
				return _changeRate;
			}
			set
			{
				if (_changeRate == value)
				{
					return;
				}
				_changeRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("applyToPosition")] 
		public CBool ApplyToPosition
		{
			get
			{
				if (_applyToPosition == null)
				{
					_applyToPosition = (CBool) CR2WTypeManager.Create("Bool", "applyToPosition", cr2w, this);
				}
				return _applyToPosition;
			}
			set
			{
				if (_applyToPosition == value)
				{
					return;
				}
				_applyToPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("worldSpaceOffset")] 
		public CBool WorldSpaceOffset
		{
			get
			{
				if (_worldSpaceOffset == null)
				{
					_worldSpaceOffset = (CBool) CR2WTypeManager.Create("Bool", "worldSpaceOffset", cr2w, this);
				}
				return _worldSpaceOffset;
			}
			set
			{
				if (_worldSpaceOffset == value)
				{
					return;
				}
				_worldSpaceOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("noiseType")] 
		public CEnum<ENoiseType> NoiseType
		{
			get
			{
				if (_noiseType == null)
				{
					_noiseType = (CEnum<ENoiseType>) CR2WTypeManager.Create("ENoiseType", "noiseType", cr2w, this);
				}
				return _noiseType;
			}
			set
			{
				if (_noiseType == value)
				{
					return;
				}
				_noiseType = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorNoise(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
