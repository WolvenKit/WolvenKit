using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entParticlesComponent : entIVisualComponent
	{
		private CFloat _emissionRate;
		private rRef<CParticleSystem> _particleSystem;
		private CFloat _autoHideRange;
		private CEnum<RenderSceneLayerMask> _renderLayerMask;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("emissionRate")] 
		public CFloat EmissionRate
		{
			get
			{
				if (_emissionRate == null)
				{
					_emissionRate = (CFloat) CR2WTypeManager.Create("Float", "emissionRate", cr2w, this);
				}
				return _emissionRate;
			}
			set
			{
				if (_emissionRate == value)
				{
					return;
				}
				_emissionRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("autoHideRange")] 
		public CFloat AutoHideRange
		{
			get
			{
				if (_autoHideRange == null)
				{
					_autoHideRange = (CFloat) CR2WTypeManager.Create("Float", "autoHideRange", cr2w, this);
				}
				return _autoHideRange;
			}
			set
			{
				if (_autoHideRange == value)
				{
					return;
				}
				_autoHideRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public entParticlesComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
