using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRandomizerNode : scnSceneGraphNode
	{
		[Ordinal(3)] 
		[RED("mode")] 
		public CEnum<scnRandomizerMode> Mode
		{
			get => GetPropertyValue<CEnum<scnRandomizerMode>>();
			set => SetPropertyValue<CEnum<scnRandomizerMode>>(value);
		}

		[Ordinal(4)] 
		[RED("numOutSockets")] 
		public CUInt32 NumOutSockets
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("weights", 32)] 
		public CArrayFixedSize<CUInt8> Weights
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt8>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt8>>(value);
		}

		public scnRandomizerNode()
		{
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();
			Weights = new(32);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
