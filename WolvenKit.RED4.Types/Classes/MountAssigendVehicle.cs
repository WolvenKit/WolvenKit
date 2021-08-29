using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MountAssigendVehicle : AIVehicleTaskAbstract
	{
		private CEnum<AIbehaviorUpdateOutcome> _result;

		[Ordinal(0)] 
		[RED("result")] 
		public CEnum<AIbehaviorUpdateOutcome> Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}
	}
}
