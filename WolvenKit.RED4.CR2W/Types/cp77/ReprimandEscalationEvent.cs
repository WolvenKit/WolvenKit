using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReprimandEscalationEvent : redEvent
	{
		private CBool _startReprimand;
		private CBool _startDeescalate;

		[Ordinal(0)] 
		[RED("startReprimand")] 
		public CBool StartReprimand
		{
			get => GetProperty(ref _startReprimand);
			set => SetProperty(ref _startReprimand, value);
		}

		[Ordinal(1)] 
		[RED("startDeescalate")] 
		public CBool StartDeescalate
		{
			get => GetProperty(ref _startDeescalate);
			set => SetProperty(ref _startDeescalate, value);
		}

		public ReprimandEscalationEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
