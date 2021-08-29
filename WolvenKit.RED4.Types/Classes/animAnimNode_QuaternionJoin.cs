using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_QuaternionJoin : animAnimNode_QuaternionValue
	{
		private animQuaternionLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animQuaternionLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}
	}
}
