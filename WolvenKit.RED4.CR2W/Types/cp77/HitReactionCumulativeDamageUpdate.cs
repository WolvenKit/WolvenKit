using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitReactionCumulativeDamageUpdate : redEvent
	{
		private CFloat _prevUpdateTime;

		[Ordinal(0)] 
		[RED("prevUpdateTime")] 
		public CFloat PrevUpdateTime
		{
			get => GetProperty(ref _prevUpdateTime);
			set => SetProperty(ref _prevUpdateTime, value);
		}

		public HitReactionCumulativeDamageUpdate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
