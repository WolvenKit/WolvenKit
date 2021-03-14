using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEffectInstance : CVariable
	{
		private scnEffectInstanceId _effectInstanceId;
		private worldCompiledEffectInfo _compiledEffect;

		[Ordinal(0)] 
		[RED("effectInstanceId")] 
		public scnEffectInstanceId EffectInstanceId
		{
			get
			{
				if (_effectInstanceId == null)
				{
					_effectInstanceId = (scnEffectInstanceId) CR2WTypeManager.Create("scnEffectInstanceId", "effectInstanceId", cr2w, this);
				}
				return _effectInstanceId;
			}
			set
			{
				if (_effectInstanceId == value)
				{
					return;
				}
				_effectInstanceId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("compiledEffect")] 
		public worldCompiledEffectInfo CompiledEffect
		{
			get
			{
				if (_compiledEffect == null)
				{
					_compiledEffect = (worldCompiledEffectInfo) CR2WTypeManager.Create("worldCompiledEffectInfo", "compiledEffect", cr2w, this);
				}
				return _compiledEffect;
			}
			set
			{
				if (_compiledEffect == value)
				{
					return;
				}
				_compiledEffect = value;
				PropertySet(this);
			}
		}

		public scnEffectInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
