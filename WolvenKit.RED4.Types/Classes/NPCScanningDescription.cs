using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCScanningDescription : ObjectScanningDescription
	{
		private TweakDBID _nPCGameplayDescription;
		private CArray<TweakDBID> _nPCCustomDescriptions;

		[Ordinal(0)] 
		[RED("NPCGameplayDescription")] 
		public TweakDBID NPCGameplayDescription
		{
			get => GetProperty(ref _nPCGameplayDescription);
			set => SetProperty(ref _nPCGameplayDescription, value);
		}

		[Ordinal(1)] 
		[RED("NPCCustomDescriptions")] 
		public CArray<TweakDBID> NPCCustomDescriptions
		{
			get => GetProperty(ref _nPCCustomDescriptions);
			set => SetProperty(ref _nPCCustomDescriptions, value);
		}
	}
}
