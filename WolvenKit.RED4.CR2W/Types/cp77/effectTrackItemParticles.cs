using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemParticles : effectTrackItem
	{
		private rRef<CParticleSystem> _particleSystem;
		private effectEffectParameterEvaluatorFloat _emissionScale;
		private effectEffectParameterEvaluatorFloat _alpha;
		private effectEffectParameterEvaluatorFloat _size;
		private effectEffectParameterEvaluatorFloat _velocity;
		private CName _soundPositionName;
		private Vector3 _soundPositionOffset;
		private CEnum<RenderSceneLayerMask> _renderLayerMask;

		[Ordinal(3)] 
		[RED("particleSystem")] 
		public rRef<CParticleSystem> ParticleSystem
		{
			get
			{
				if (_particleSystem == null)
				{
					_particleSystem = (rRef<CParticleSystem>) CR2WTypeManager.Create("rRef:CParticleSystem", "particleSystem", cr2w, this);
				}
				return _particleSystem;
			}
			set
			{
				if (_particleSystem == value)
				{
					return;
				}
				_particleSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("emissionScale")] 
		public effectEffectParameterEvaluatorFloat EmissionScale
		{
			get
			{
				if (_emissionScale == null)
				{
					_emissionScale = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "emissionScale", cr2w, this);
				}
				return _emissionScale;
			}
			set
			{
				if (_emissionScale == value)
				{
					return;
				}
				_emissionScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("alpha")] 
		public effectEffectParameterEvaluatorFloat Alpha
		{
			get
			{
				if (_alpha == null)
				{
					_alpha = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "alpha", cr2w, this);
				}
				return _alpha;
			}
			set
			{
				if (_alpha == value)
				{
					return;
				}
				_alpha = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("size")] 
		public effectEffectParameterEvaluatorFloat Size
		{
			get
			{
				if (_size == null)
				{
					_size = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("velocity")] 
		public effectEffectParameterEvaluatorFloat Velocity
		{
			get
			{
				if (_velocity == null)
				{
					_velocity = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "velocity", cr2w, this);
				}
				return _velocity;
			}
			set
			{
				if (_velocity == value)
				{
					return;
				}
				_velocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("soundPositionName")] 
		public CName SoundPositionName
		{
			get
			{
				if (_soundPositionName == null)
				{
					_soundPositionName = (CName) CR2WTypeManager.Create("CName", "soundPositionName", cr2w, this);
				}
				return _soundPositionName;
			}
			set
			{
				if (_soundPositionName == value)
				{
					return;
				}
				_soundPositionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("soundPositionOffset")] 
		public Vector3 SoundPositionOffset
		{
			get
			{
				if (_soundPositionOffset == null)
				{
					_soundPositionOffset = (Vector3) CR2WTypeManager.Create("Vector3", "soundPositionOffset", cr2w, this);
				}
				return _soundPositionOffset;
			}
			set
			{
				if (_soundPositionOffset == value)
				{
					return;
				}
				_soundPositionOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("renderLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderLayerMask
		{
			get
			{
				if (_renderLayerMask == null)
				{
					_renderLayerMask = (CEnum<RenderSceneLayerMask>) CR2WTypeManager.Create("RenderSceneLayerMask", "renderLayerMask", cr2w, this);
				}
				return _renderLayerMask;
			}
			set
			{
				if (_renderLayerMask == value)
				{
					return;
				}
				_renderLayerMask = value;
				PropertySet(this);
			}
		}

		public effectTrackItemParticles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
