using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPlayerMovingPrereqState : PlayerStateMachinePrereqState
	{
		private CBool _bbValue;

		[Ordinal(3)] 
		[RED("bbValue")] 
		public CBool BbValue
		{
			get => GetProperty(ref _bbValue);
			set => SetProperty(ref _bbValue, value);
		}

		public IsPlayerMovingPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
