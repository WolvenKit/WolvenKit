using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScavengeComponent : gameScriptableComponent
	{
		private CArray<CWeakHandle<gameObject>> _scavengeTargets;

		[Ordinal(5)] 
		[RED("scavengeTargets")] 
		public CArray<CWeakHandle<gameObject>> ScavengeTargets
		{
			get => GetProperty(ref _scavengeTargets);
			set => SetProperty(ref _scavengeTargets, value);
		}
	}
}
