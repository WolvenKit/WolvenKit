using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEnvDisplaySettingsParams : CVariable
	{
		private CBool _enableInstantAdaptation;
		private CBool _enableGlobalLightingTrajectory;
		private CBool _enableEnvProbeInstantUpdate;
		private CBool _allowEnvProbeUpdate;
		private CBool _allowBloom;
		private CBool _allowColorMod;
		private CBool _allowAntialiasing;
		private CBool _allowGlobalFog;
		private CBool _allowDOF;
		private CBool _allowSSAO;
		private CBool _allowCloudsShadow;
		private CBool _allowWaterShader;
		private CFloat _gamma;

		[Ordinal(0)] 
		[RED("enableInstantAdaptation")] 
		public CBool EnableInstantAdaptation
		{
			get
			{
				if (_enableInstantAdaptation == null)
				{
					_enableInstantAdaptation = (CBool) CR2WTypeManager.Create("Bool", "enableInstantAdaptation", cr2w, this);
				}
				return _enableInstantAdaptation;
			}
			set
			{
				if (_enableInstantAdaptation == value)
				{
					return;
				}
				_enableInstantAdaptation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enableGlobalLightingTrajectory")] 
		public CBool EnableGlobalLightingTrajectory
		{
			get
			{
				if (_enableGlobalLightingTrajectory == null)
				{
					_enableGlobalLightingTrajectory = (CBool) CR2WTypeManager.Create("Bool", "enableGlobalLightingTrajectory", cr2w, this);
				}
				return _enableGlobalLightingTrajectory;
			}
			set
			{
				if (_enableGlobalLightingTrajectory == value)
				{
					return;
				}
				_enableGlobalLightingTrajectory = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enableEnvProbeInstantUpdate")] 
		public CBool EnableEnvProbeInstantUpdate
		{
			get
			{
				if (_enableEnvProbeInstantUpdate == null)
				{
					_enableEnvProbeInstantUpdate = (CBool) CR2WTypeManager.Create("Bool", "enableEnvProbeInstantUpdate", cr2w, this);
				}
				return _enableEnvProbeInstantUpdate;
			}
			set
			{
				if (_enableEnvProbeInstantUpdate == value)
				{
					return;
				}
				_enableEnvProbeInstantUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("allowEnvProbeUpdate")] 
		public CBool AllowEnvProbeUpdate
		{
			get
			{
				if (_allowEnvProbeUpdate == null)
				{
					_allowEnvProbeUpdate = (CBool) CR2WTypeManager.Create("Bool", "allowEnvProbeUpdate", cr2w, this);
				}
				return _allowEnvProbeUpdate;
			}
			set
			{
				if (_allowEnvProbeUpdate == value)
				{
					return;
				}
				_allowEnvProbeUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("allowBloom")] 
		public CBool AllowBloom
		{
			get
			{
				if (_allowBloom == null)
				{
					_allowBloom = (CBool) CR2WTypeManager.Create("Bool", "allowBloom", cr2w, this);
				}
				return _allowBloom;
			}
			set
			{
				if (_allowBloom == value)
				{
					return;
				}
				_allowBloom = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("allowColorMod")] 
		public CBool AllowColorMod
		{
			get
			{
				if (_allowColorMod == null)
				{
					_allowColorMod = (CBool) CR2WTypeManager.Create("Bool", "allowColorMod", cr2w, this);
				}
				return _allowColorMod;
			}
			set
			{
				if (_allowColorMod == value)
				{
					return;
				}
				_allowColorMod = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("allowAntialiasing")] 
		public CBool AllowAntialiasing
		{
			get
			{
				if (_allowAntialiasing == null)
				{
					_allowAntialiasing = (CBool) CR2WTypeManager.Create("Bool", "allowAntialiasing", cr2w, this);
				}
				return _allowAntialiasing;
			}
			set
			{
				if (_allowAntialiasing == value)
				{
					return;
				}
				_allowAntialiasing = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("allowGlobalFog")] 
		public CBool AllowGlobalFog
		{
			get
			{
				if (_allowGlobalFog == null)
				{
					_allowGlobalFog = (CBool) CR2WTypeManager.Create("Bool", "allowGlobalFog", cr2w, this);
				}
				return _allowGlobalFog;
			}
			set
			{
				if (_allowGlobalFog == value)
				{
					return;
				}
				_allowGlobalFog = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("allowDOF")] 
		public CBool AllowDOF
		{
			get
			{
				if (_allowDOF == null)
				{
					_allowDOF = (CBool) CR2WTypeManager.Create("Bool", "allowDOF", cr2w, this);
				}
				return _allowDOF;
			}
			set
			{
				if (_allowDOF == value)
				{
					return;
				}
				_allowDOF = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("allowSSAO")] 
		public CBool AllowSSAO
		{
			get
			{
				if (_allowSSAO == null)
				{
					_allowSSAO = (CBool) CR2WTypeManager.Create("Bool", "allowSSAO", cr2w, this);
				}
				return _allowSSAO;
			}
			set
			{
				if (_allowSSAO == value)
				{
					return;
				}
				_allowSSAO = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("allowCloudsShadow")] 
		public CBool AllowCloudsShadow
		{
			get
			{
				if (_allowCloudsShadow == null)
				{
					_allowCloudsShadow = (CBool) CR2WTypeManager.Create("Bool", "allowCloudsShadow", cr2w, this);
				}
				return _allowCloudsShadow;
			}
			set
			{
				if (_allowCloudsShadow == value)
				{
					return;
				}
				_allowCloudsShadow = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("allowWaterShader")] 
		public CBool AllowWaterShader
		{
			get
			{
				if (_allowWaterShader == null)
				{
					_allowWaterShader = (CBool) CR2WTypeManager.Create("Bool", "allowWaterShader", cr2w, this);
				}
				return _allowWaterShader;
			}
			set
			{
				if (_allowWaterShader == value)
				{
					return;
				}
				_allowWaterShader = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("gamma")] 
		public CFloat Gamma
		{
			get
			{
				if (_gamma == null)
				{
					_gamma = (CFloat) CR2WTypeManager.Create("Float", "gamma", cr2w, this);
				}
				return _gamma;
			}
			set
			{
				if (_gamma == value)
				{
					return;
				}
				_gamma = value;
				PropertySet(this);
			}
		}

		public CEnvDisplaySettingsParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
