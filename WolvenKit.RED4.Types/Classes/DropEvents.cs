using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropEvents : CarriedObjectEvents
	{
		private CBool _ragdollReenabled;

		[Ordinal(9)] 
		[RED("ragdollReenabled")] 
		public CBool RagdollReenabled
		{
			get => GetProperty(ref _ragdollReenabled);
			set => SetProperty(ref _ragdollReenabled, value);
		}
	}
}
