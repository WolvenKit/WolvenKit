using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEffectEntry : CVariable
	{
		private scnEffectInstanceId _effectInstanceId;
		private CName _effectName;

		[Ordinal(0)] 
		[RED("effectInstanceId")] 
		public scnEffectInstanceId EffectInstanceId
		{
			get => GetProperty(ref _effectInstanceId);
			set => SetProperty(ref _effectInstanceId, value);
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		public scnEffectEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
