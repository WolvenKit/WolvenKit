using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeQuickhackKillEntry : RedBaseClass
	{
		private CWeakHandle<gameObject> _source;
		private CArray<CWeakHandle<gameObject>> _targets;
		private CArray<CFloat> _timestamps;

		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("targets")] 
		public CArray<CWeakHandle<gameObject>> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(2)] 
		[RED("timestamps")] 
		public CArray<CFloat> Timestamps
		{
			get => GetProperty(ref _timestamps);
			set => SetProperty(ref _timestamps, value);
		}
	}
}
