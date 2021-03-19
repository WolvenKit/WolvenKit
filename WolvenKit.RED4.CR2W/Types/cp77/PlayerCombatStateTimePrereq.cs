using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatStateTimePrereq : gameIScriptablePrereq
	{
		private CFloat _minTime;
		private CFloat _maxTime;

		[Ordinal(0)] 
		[RED("minTime")] 
		public CFloat MinTime
		{
			get => GetProperty(ref _minTime);
			set => SetProperty(ref _minTime, value);
		}

		[Ordinal(1)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetProperty(ref _maxTime);
			set => SetProperty(ref _maxTime, value);
		}

		public PlayerCombatStateTimePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
