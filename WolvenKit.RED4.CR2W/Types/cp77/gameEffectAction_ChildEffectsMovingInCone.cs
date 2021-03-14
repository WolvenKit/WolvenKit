using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_ChildEffectsMovingInCone : gameEffectPostAction
	{
		private CUInt32 _effectsCount;
		private CName _effectTagInThisFile;
		private CFloat _coneAngle;
		private CFloat _minEffectDuration;
		private CFloat _maxEffectDuration;
		private CBool _twoDimensional;

		[Ordinal(0)] 
		[RED("effectsCount")] 
		public CUInt32 EffectsCount
		{
			get
			{
				if (_effectsCount == null)
				{
					_effectsCount = (CUInt32) CR2WTypeManager.Create("Uint32", "effectsCount", cr2w, this);
				}
				return _effectsCount;
			}
			set
			{
				if (_effectsCount == value)
				{
					return;
				}
				_effectsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectTagInThisFile")] 
		public CName EffectTagInThisFile
		{
			get
			{
				if (_effectTagInThisFile == null)
				{
					_effectTagInThisFile = (CName) CR2WTypeManager.Create("CName", "effectTagInThisFile", cr2w, this);
				}
				return _effectTagInThisFile;
			}
			set
			{
				if (_effectTagInThisFile == value)
				{
					return;
				}
				_effectTagInThisFile = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("coneAngle")] 
		public CFloat ConeAngle
		{
			get
			{
				if (_coneAngle == null)
				{
					_coneAngle = (CFloat) CR2WTypeManager.Create("Float", "coneAngle", cr2w, this);
				}
				return _coneAngle;
			}
			set
			{
				if (_coneAngle == value)
				{
					return;
				}
				_coneAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("minEffectDuration")] 
		public CFloat MinEffectDuration
		{
			get
			{
				if (_minEffectDuration == null)
				{
					_minEffectDuration = (CFloat) CR2WTypeManager.Create("Float", "minEffectDuration", cr2w, this);
				}
				return _minEffectDuration;
			}
			set
			{
				if (_minEffectDuration == value)
				{
					return;
				}
				_minEffectDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxEffectDuration")] 
		public CFloat MaxEffectDuration
		{
			get
			{
				if (_maxEffectDuration == null)
				{
					_maxEffectDuration = (CFloat) CR2WTypeManager.Create("Float", "maxEffectDuration", cr2w, this);
				}
				return _maxEffectDuration;
			}
			set
			{
				if (_maxEffectDuration == value)
				{
					return;
				}
				_maxEffectDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("twoDimensional")] 
		public CBool TwoDimensional
		{
			get
			{
				if (_twoDimensional == null)
				{
					_twoDimensional = (CBool) CR2WTypeManager.Create("Bool", "twoDimensional", cr2w, this);
				}
				return _twoDimensional;
			}
			set
			{
				if (_twoDimensional == value)
				{
					return;
				}
				_twoDimensional = value;
				PropertySet(this);
			}
		}

		public gameEffectAction_ChildEffectsMovingInCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
