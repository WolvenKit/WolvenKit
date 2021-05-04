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
			get => GetProperty(ref _effectInstanceId);
			set => SetProperty(ref _effectInstanceId, value);
		}

		[Ordinal(1)] 
		[RED("compiledEffect")] 
		public worldCompiledEffectInfo CompiledEffect
		{
			get => GetProperty(ref _compiledEffect);
			set => SetProperty(ref _compiledEffect, value);
		}

		public scnEffectInstance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
