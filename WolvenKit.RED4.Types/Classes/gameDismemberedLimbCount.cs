using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDismemberedLimbCount : RedBaseClass
	{
		private CUInt32 _fleshDismemberments;
		private CUInt32 _cyberDismemberments;

		[Ordinal(0)] 
		[RED("fleshDismemberments")] 
		public CUInt32 FleshDismemberments
		{
			get => GetProperty(ref _fleshDismemberments);
			set => SetProperty(ref _fleshDismemberments, value);
		}

		[Ordinal(1)] 
		[RED("cyberDismemberments")] 
		public CUInt32 CyberDismemberments
		{
			get => GetProperty(ref _cyberDismemberments);
			set => SetProperty(ref _cyberDismemberments, value);
		}
	}
}
