using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DEBUG_VisualRecord : RedBaseClass
	{
		private CArray<CUInt32> _layerIDs;
		private CWeakHandle<ScriptedPuppet> _puppet;
		private CBool _infiniteDuration;
		private CFloat _showDuration;

		[Ordinal(0)] 
		[RED("layerIDs")] 
		public CArray<CUInt32> LayerIDs
		{
			get => GetProperty(ref _layerIDs);
			set => SetProperty(ref _layerIDs, value);
		}

		[Ordinal(1)] 
		[RED("puppet")] 
		public CWeakHandle<ScriptedPuppet> Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(2)] 
		[RED("infiniteDuration")] 
		public CBool InfiniteDuration
		{
			get => GetProperty(ref _infiniteDuration);
			set => SetProperty(ref _infiniteDuration, value);
		}

		[Ordinal(3)] 
		[RED("showDuration")] 
		public CFloat ShowDuration
		{
			get => GetProperty(ref _showDuration);
			set => SetProperty(ref _showDuration, value);
		}
	}
}
