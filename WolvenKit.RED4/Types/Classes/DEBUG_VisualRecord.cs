using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DEBUG_VisualRecord : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("layerIDs")] 
		public CArray<CUInt32> LayerIDs
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("puppet")] 
		public CWeakHandle<ScriptedPuppet> Puppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(2)] 
		[RED("infiniteDuration")] 
		public CBool InfiniteDuration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("showDuration")] 
		public CFloat ShowDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DEBUG_VisualRecord()
		{
			LayerIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
