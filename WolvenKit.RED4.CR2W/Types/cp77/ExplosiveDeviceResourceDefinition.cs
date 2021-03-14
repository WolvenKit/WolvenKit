using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDeviceResourceDefinition : CVariable
	{
		private TweakDBID _damageType;
		private gameFxResource _vfxResource;
		private CArray<CName> _vfxEventNamesOnExplosion;
		private CArray<gameFxResource> _vfxResourceOnFirstHit;
		private CFloat _executionDelay;
		private CEnum<EExplosiveAdditionalGameEffectType> _additionalGameEffectType;
		private CBool _dontHighlightOnLookat;

		[Ordinal(0)] 
		[RED("damageType")] 
		public TweakDBID DamageType
		{
			get
			{
				if (_damageType == null)
				{
					_damageType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "damageType", cr2w, this);
				}
				return _damageType;
			}
			set
			{
				if (_damageType == value)
				{
					return;
				}
				_damageType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get
			{
				if (_vfxResource == null)
				{
					_vfxResource = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "vfxResource", cr2w, this);
				}
				return _vfxResource;
			}
			set
			{
				if (_vfxResource == value)
				{
					return;
				}
				_vfxResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vfxEventNamesOnExplosion")] 
		public CArray<CName> VfxEventNamesOnExplosion
		{
			get
			{
				if (_vfxEventNamesOnExplosion == null)
				{
					_vfxEventNamesOnExplosion = (CArray<CName>) CR2WTypeManager.Create("array:CName", "vfxEventNamesOnExplosion", cr2w, this);
				}
				return _vfxEventNamesOnExplosion;
			}
			set
			{
				if (_vfxEventNamesOnExplosion == value)
				{
					return;
				}
				_vfxEventNamesOnExplosion = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vfxResourceOnFirstHit")] 
		public CArray<gameFxResource> VfxResourceOnFirstHit
		{
			get
			{
				if (_vfxResourceOnFirstHit == null)
				{
					_vfxResourceOnFirstHit = (CArray<gameFxResource>) CR2WTypeManager.Create("array:gameFxResource", "vfxResourceOnFirstHit", cr2w, this);
				}
				return _vfxResourceOnFirstHit;
			}
			set
			{
				if (_vfxResourceOnFirstHit == value)
				{
					return;
				}
				_vfxResourceOnFirstHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("executionDelay")] 
		public CFloat ExecutionDelay
		{
			get
			{
				if (_executionDelay == null)
				{
					_executionDelay = (CFloat) CR2WTypeManager.Create("Float", "executionDelay", cr2w, this);
				}
				return _executionDelay;
			}
			set
			{
				if (_executionDelay == value)
				{
					return;
				}
				_executionDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("additionalGameEffectType")] 
		public CEnum<EExplosiveAdditionalGameEffectType> AdditionalGameEffectType
		{
			get
			{
				if (_additionalGameEffectType == null)
				{
					_additionalGameEffectType = (CEnum<EExplosiveAdditionalGameEffectType>) CR2WTypeManager.Create("EExplosiveAdditionalGameEffectType", "additionalGameEffectType", cr2w, this);
				}
				return _additionalGameEffectType;
			}
			set
			{
				if (_additionalGameEffectType == value)
				{
					return;
				}
				_additionalGameEffectType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("dontHighlightOnLookat")] 
		public CBool DontHighlightOnLookat
		{
			get
			{
				if (_dontHighlightOnLookat == null)
				{
					_dontHighlightOnLookat = (CBool) CR2WTypeManager.Create("Bool", "dontHighlightOnLookat", cr2w, this);
				}
				return _dontHighlightOnLookat;
			}
			set
			{
				if (_dontHighlightOnLookat == value)
				{
					return;
				}
				_dontHighlightOnLookat = value;
				PropertySet(this);
			}
		}

		public ExplosiveDeviceResourceDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
