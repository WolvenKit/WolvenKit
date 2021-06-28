using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLipsyncAnimSetSRRef : CVariable
	{
		private rRef<animAnimSet> _lipsyncAnimSet;
		private raRef<animAnimSet> _asyncRefLipsyncAnimSet;

		[Ordinal(0)] 
		[RED("lipsyncAnimSet")] 
		public rRef<animAnimSet> LipsyncAnimSet
		{
			get => GetProperty(ref _lipsyncAnimSet);
			set => SetProperty(ref _lipsyncAnimSet, value);
		}

		[Ordinal(1)] 
		[RED("asyncRefLipsyncAnimSet")] 
		public raRef<animAnimSet> AsyncRefLipsyncAnimSet
		{
			get => GetProperty(ref _asyncRefLipsyncAnimSet);
			set => SetProperty(ref _asyncRefLipsyncAnimSet, value);
		}

		public scnLipsyncAnimSetSRRef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
