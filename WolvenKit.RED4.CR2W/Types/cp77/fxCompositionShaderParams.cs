using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class fxCompositionShaderParams : CVariable
	{
		private CFloat _glitchParam;
		private CFloat _glitchParam1;
		private CFloat _health;
		private CFloat _visionActiveTime;
		private CFloat _uiFactor;
		private CFloat _uiPassthroughFactor;
		private CFloat _mainRenderFactor;
		private CFloat _blurredRenderFactor;
		private CFloat _backgroundTextureFactor;
		private CFloat _backgroundBlurRadius;
		private Vector2 _sphericalDistPower;
		private Vector2 _shadowDistance;
		private CFloat _shadowIntensity;
		private CFloat _shadowRadius;
		private CFloat _glowIntensity;
		private CFloat _glowTresholdStart;
		private CFloat _glowTresholdEnd;
		private CFloat _glowBlurRadius;
		private CFloat _vignetteStart;
		private CFloat _vignetteEnd;
		private CFloat _vignetteIntensity;
		private CFloat _blurredRenderSaturation;
		private CFloat _uiSaturation;
		private CFloat _chromaticAberrationStrength;
		private Vector2 _uiLayer2Scale;
		private Vector2 _uiLayer3Scale;
		private Vector2 _uiLayer4Scale;
		private CFloat _uiLayer2Weight;
		private CFloat _uiLayer3Weight;
		private CFloat _uiLayer4Weight;

		[Ordinal(0)] 
		[RED("glitchParam")] 
		public CFloat GlitchParam
		{
			get
			{
				if (_glitchParam == null)
				{
					_glitchParam = (CFloat) CR2WTypeManager.Create("Float", "glitchParam", cr2w, this);
				}
				return _glitchParam;
			}
			set
			{
				if (_glitchParam == value)
				{
					return;
				}
				_glitchParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("glitchParam1")] 
		public CFloat GlitchParam1
		{
			get
			{
				if (_glitchParam1 == null)
				{
					_glitchParam1 = (CFloat) CR2WTypeManager.Create("Float", "glitchParam1", cr2w, this);
				}
				return _glitchParam1;
			}
			set
			{
				if (_glitchParam1 == value)
				{
					return;
				}
				_glitchParam1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("health")] 
		public CFloat Health
		{
			get
			{
				if (_health == null)
				{
					_health = (CFloat) CR2WTypeManager.Create("Float", "health", cr2w, this);
				}
				return _health;
			}
			set
			{
				if (_health == value)
				{
					return;
				}
				_health = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("visionActiveTime")] 
		public CFloat VisionActiveTime
		{
			get
			{
				if (_visionActiveTime == null)
				{
					_visionActiveTime = (CFloat) CR2WTypeManager.Create("Float", "visionActiveTime", cr2w, this);
				}
				return _visionActiveTime;
			}
			set
			{
				if (_visionActiveTime == value)
				{
					return;
				}
				_visionActiveTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("uiFactor")] 
		public CFloat UiFactor
		{
			get
			{
				if (_uiFactor == null)
				{
					_uiFactor = (CFloat) CR2WTypeManager.Create("Float", "uiFactor", cr2w, this);
				}
				return _uiFactor;
			}
			set
			{
				if (_uiFactor == value)
				{
					return;
				}
				_uiFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("uiPassthroughFactor")] 
		public CFloat UiPassthroughFactor
		{
			get
			{
				if (_uiPassthroughFactor == null)
				{
					_uiPassthroughFactor = (CFloat) CR2WTypeManager.Create("Float", "uiPassthroughFactor", cr2w, this);
				}
				return _uiPassthroughFactor;
			}
			set
			{
				if (_uiPassthroughFactor == value)
				{
					return;
				}
				_uiPassthroughFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("mainRenderFactor")] 
		public CFloat MainRenderFactor
		{
			get
			{
				if (_mainRenderFactor == null)
				{
					_mainRenderFactor = (CFloat) CR2WTypeManager.Create("Float", "mainRenderFactor", cr2w, this);
				}
				return _mainRenderFactor;
			}
			set
			{
				if (_mainRenderFactor == value)
				{
					return;
				}
				_mainRenderFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("blurredRenderFactor")] 
		public CFloat BlurredRenderFactor
		{
			get
			{
				if (_blurredRenderFactor == null)
				{
					_blurredRenderFactor = (CFloat) CR2WTypeManager.Create("Float", "blurredRenderFactor", cr2w, this);
				}
				return _blurredRenderFactor;
			}
			set
			{
				if (_blurredRenderFactor == value)
				{
					return;
				}
				_blurredRenderFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("backgroundTextureFactor")] 
		public CFloat BackgroundTextureFactor
		{
			get
			{
				if (_backgroundTextureFactor == null)
				{
					_backgroundTextureFactor = (CFloat) CR2WTypeManager.Create("Float", "backgroundTextureFactor", cr2w, this);
				}
				return _backgroundTextureFactor;
			}
			set
			{
				if (_backgroundTextureFactor == value)
				{
					return;
				}
				_backgroundTextureFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("backgroundBlurRadius")] 
		public CFloat BackgroundBlurRadius
		{
			get
			{
				if (_backgroundBlurRadius == null)
				{
					_backgroundBlurRadius = (CFloat) CR2WTypeManager.Create("Float", "backgroundBlurRadius", cr2w, this);
				}
				return _backgroundBlurRadius;
			}
			set
			{
				if (_backgroundBlurRadius == value)
				{
					return;
				}
				_backgroundBlurRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("sphericalDistPower")] 
		public Vector2 SphericalDistPower
		{
			get
			{
				if (_sphericalDistPower == null)
				{
					_sphericalDistPower = (Vector2) CR2WTypeManager.Create("Vector2", "sphericalDistPower", cr2w, this);
				}
				return _sphericalDistPower;
			}
			set
			{
				if (_sphericalDistPower == value)
				{
					return;
				}
				_sphericalDistPower = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("shadowDistance")] 
		public Vector2 ShadowDistance
		{
			get
			{
				if (_shadowDistance == null)
				{
					_shadowDistance = (Vector2) CR2WTypeManager.Create("Vector2", "shadowDistance", cr2w, this);
				}
				return _shadowDistance;
			}
			set
			{
				if (_shadowDistance == value)
				{
					return;
				}
				_shadowDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("shadowIntensity")] 
		public CFloat ShadowIntensity
		{
			get
			{
				if (_shadowIntensity == null)
				{
					_shadowIntensity = (CFloat) CR2WTypeManager.Create("Float", "shadowIntensity", cr2w, this);
				}
				return _shadowIntensity;
			}
			set
			{
				if (_shadowIntensity == value)
				{
					return;
				}
				_shadowIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("shadowRadius")] 
		public CFloat ShadowRadius
		{
			get
			{
				if (_shadowRadius == null)
				{
					_shadowRadius = (CFloat) CR2WTypeManager.Create("Float", "shadowRadius", cr2w, this);
				}
				return _shadowRadius;
			}
			set
			{
				if (_shadowRadius == value)
				{
					return;
				}
				_shadowRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("glowIntensity")] 
		public CFloat GlowIntensity
		{
			get
			{
				if (_glowIntensity == null)
				{
					_glowIntensity = (CFloat) CR2WTypeManager.Create("Float", "glowIntensity", cr2w, this);
				}
				return _glowIntensity;
			}
			set
			{
				if (_glowIntensity == value)
				{
					return;
				}
				_glowIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("glowTresholdStart")] 
		public CFloat GlowTresholdStart
		{
			get
			{
				if (_glowTresholdStart == null)
				{
					_glowTresholdStart = (CFloat) CR2WTypeManager.Create("Float", "glowTresholdStart", cr2w, this);
				}
				return _glowTresholdStart;
			}
			set
			{
				if (_glowTresholdStart == value)
				{
					return;
				}
				_glowTresholdStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("glowTresholdEnd")] 
		public CFloat GlowTresholdEnd
		{
			get
			{
				if (_glowTresholdEnd == null)
				{
					_glowTresholdEnd = (CFloat) CR2WTypeManager.Create("Float", "glowTresholdEnd", cr2w, this);
				}
				return _glowTresholdEnd;
			}
			set
			{
				if (_glowTresholdEnd == value)
				{
					return;
				}
				_glowTresholdEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("glowBlurRadius")] 
		public CFloat GlowBlurRadius
		{
			get
			{
				if (_glowBlurRadius == null)
				{
					_glowBlurRadius = (CFloat) CR2WTypeManager.Create("Float", "glowBlurRadius", cr2w, this);
				}
				return _glowBlurRadius;
			}
			set
			{
				if (_glowBlurRadius == value)
				{
					return;
				}
				_glowBlurRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("vignetteStart")] 
		public CFloat VignetteStart
		{
			get
			{
				if (_vignetteStart == null)
				{
					_vignetteStart = (CFloat) CR2WTypeManager.Create("Float", "vignetteStart", cr2w, this);
				}
				return _vignetteStart;
			}
			set
			{
				if (_vignetteStart == value)
				{
					return;
				}
				_vignetteStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("vignetteEnd")] 
		public CFloat VignetteEnd
		{
			get
			{
				if (_vignetteEnd == null)
				{
					_vignetteEnd = (CFloat) CR2WTypeManager.Create("Float", "vignetteEnd", cr2w, this);
				}
				return _vignetteEnd;
			}
			set
			{
				if (_vignetteEnd == value)
				{
					return;
				}
				_vignetteEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("vignetteIntensity")] 
		public CFloat VignetteIntensity
		{
			get
			{
				if (_vignetteIntensity == null)
				{
					_vignetteIntensity = (CFloat) CR2WTypeManager.Create("Float", "vignetteIntensity", cr2w, this);
				}
				return _vignetteIntensity;
			}
			set
			{
				if (_vignetteIntensity == value)
				{
					return;
				}
				_vignetteIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("blurredRenderSaturation")] 
		public CFloat BlurredRenderSaturation
		{
			get
			{
				if (_blurredRenderSaturation == null)
				{
					_blurredRenderSaturation = (CFloat) CR2WTypeManager.Create("Float", "blurredRenderSaturation", cr2w, this);
				}
				return _blurredRenderSaturation;
			}
			set
			{
				if (_blurredRenderSaturation == value)
				{
					return;
				}
				_blurredRenderSaturation = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("uiSaturation")] 
		public CFloat UiSaturation
		{
			get
			{
				if (_uiSaturation == null)
				{
					_uiSaturation = (CFloat) CR2WTypeManager.Create("Float", "uiSaturation", cr2w, this);
				}
				return _uiSaturation;
			}
			set
			{
				if (_uiSaturation == value)
				{
					return;
				}
				_uiSaturation = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("chromaticAberrationStrength")] 
		public CFloat ChromaticAberrationStrength
		{
			get
			{
				if (_chromaticAberrationStrength == null)
				{
					_chromaticAberrationStrength = (CFloat) CR2WTypeManager.Create("Float", "chromaticAberrationStrength", cr2w, this);
				}
				return _chromaticAberrationStrength;
			}
			set
			{
				if (_chromaticAberrationStrength == value)
				{
					return;
				}
				_chromaticAberrationStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("uiLayer2Scale")] 
		public Vector2 UiLayer2Scale
		{
			get
			{
				if (_uiLayer2Scale == null)
				{
					_uiLayer2Scale = (Vector2) CR2WTypeManager.Create("Vector2", "uiLayer2Scale", cr2w, this);
				}
				return _uiLayer2Scale;
			}
			set
			{
				if (_uiLayer2Scale == value)
				{
					return;
				}
				_uiLayer2Scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("uiLayer3Scale")] 
		public Vector2 UiLayer3Scale
		{
			get
			{
				if (_uiLayer3Scale == null)
				{
					_uiLayer3Scale = (Vector2) CR2WTypeManager.Create("Vector2", "uiLayer3Scale", cr2w, this);
				}
				return _uiLayer3Scale;
			}
			set
			{
				if (_uiLayer3Scale == value)
				{
					return;
				}
				_uiLayer3Scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("uiLayer4Scale")] 
		public Vector2 UiLayer4Scale
		{
			get
			{
				if (_uiLayer4Scale == null)
				{
					_uiLayer4Scale = (Vector2) CR2WTypeManager.Create("Vector2", "uiLayer4Scale", cr2w, this);
				}
				return _uiLayer4Scale;
			}
			set
			{
				if (_uiLayer4Scale == value)
				{
					return;
				}
				_uiLayer4Scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("uiLayer2Weight")] 
		public CFloat UiLayer2Weight
		{
			get
			{
				if (_uiLayer2Weight == null)
				{
					_uiLayer2Weight = (CFloat) CR2WTypeManager.Create("Float", "uiLayer2Weight", cr2w, this);
				}
				return _uiLayer2Weight;
			}
			set
			{
				if (_uiLayer2Weight == value)
				{
					return;
				}
				_uiLayer2Weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("uiLayer3Weight")] 
		public CFloat UiLayer3Weight
		{
			get
			{
				if (_uiLayer3Weight == null)
				{
					_uiLayer3Weight = (CFloat) CR2WTypeManager.Create("Float", "uiLayer3Weight", cr2w, this);
				}
				return _uiLayer3Weight;
			}
			set
			{
				if (_uiLayer3Weight == value)
				{
					return;
				}
				_uiLayer3Weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("uiLayer4Weight")] 
		public CFloat UiLayer4Weight
		{
			get
			{
				if (_uiLayer4Weight == null)
				{
					_uiLayer4Weight = (CFloat) CR2WTypeManager.Create("Float", "uiLayer4Weight", cr2w, this);
				}
				return _uiLayer4Weight;
			}
			set
			{
				if (_uiLayer4Weight == value)
				{
					return;
				}
				_uiLayer4Weight = value;
				PropertySet(this);
			}
		}

		public fxCompositionShaderParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
