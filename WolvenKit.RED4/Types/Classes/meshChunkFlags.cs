using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshChunkFlags : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("renderInScene")] 
		public CBool RenderInScene
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("renderInShadows")] 
		public CBool RenderInShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isTwoSided")] 
		public CBool IsTwoSided
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isRayTracedEmissive")] 
		public CBool IsRayTracedEmissive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isConsoleLOD0")] 
		public CBool IsConsoleLOD0
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("skipDynamicDecalGeneration")] 
		public CBool SkipDynamicDecalGeneration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public meshChunkFlags()
		{
			RenderInScene = true;
			RenderInShadows = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
