using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamWaterPatchData : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("animLoop")] 
		public CBool AnimLoop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("animLength")] 
		public CFloat AnimLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("nodes", 4096, 16)] 
		public CStatic<CStatic<CFloat>> Nodes
		{
			get => GetPropertyValue<CStatic<CStatic<CFloat>>>();
			set => SetPropertyValue<CStatic<CStatic<CFloat>>>(value);
		}

		public meshMeshParamWaterPatchData()
		{
			Nodes = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
