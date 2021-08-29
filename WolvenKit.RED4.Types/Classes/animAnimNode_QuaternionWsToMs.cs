using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_QuaternionWsToMs : animAnimNode_QuaternionValue
	{
		private animQuaternionLink _quaternionWs;

		[Ordinal(11)] 
		[RED("quaternionWs")] 
		public animQuaternionLink QuaternionWs
		{
			get => GetProperty(ref _quaternionWs);
			set => SetProperty(ref _quaternionWs, value);
		}
	}
}
