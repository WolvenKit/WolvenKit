using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleForbiddenAreaState : RedBaseClass
	{
		private CUInt64 _globalNodeIDHash;
		private CBool _enabled;
		private CBool _dismount;

		[Ordinal(0)] 
		[RED("globalNodeIDHash")] 
		public CUInt64 GlobalNodeIDHash
		{
			get => GetProperty(ref _globalNodeIDHash);
			set => SetProperty(ref _globalNodeIDHash, value);
		}

		[Ordinal(1)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(2)] 
		[RED("dismount")] 
		public CBool Dismount
		{
			get => GetProperty(ref _dismount);
			set => SetProperty(ref _dismount, value);
		}
	}
}
