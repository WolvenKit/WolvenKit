using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RoyceHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private CWeakHandle<NPCPuppet> _owner;
		private CHandle<RoyceComponent> _royceComponent;
		private CArray<CWeakHandle<gameWeakspotObject>> _weakspots;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("royceComponent")] 
		public CHandle<RoyceComponent> RoyceComponent
		{
			get => GetProperty(ref _royceComponent);
			set => SetProperty(ref _royceComponent, value);
		}

		[Ordinal(2)] 
		[RED("weakspots")] 
		public CArray<CWeakHandle<gameWeakspotObject>> Weakspots
		{
			get => GetProperty(ref _weakspots);
			set => SetProperty(ref _weakspots, value);
		}
	}
}
