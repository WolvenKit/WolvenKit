using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineConsumableParameterFloat : gamestateMachineActionParameterFloat
	{
		private CBool _consumed;

		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetProperty(ref _consumed);
			set => SetProperty(ref _consumed, value);
		}

		public gamestateMachineConsumableParameterFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
