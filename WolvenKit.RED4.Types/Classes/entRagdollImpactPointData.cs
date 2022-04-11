using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollImpactPointData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("worldPosition")] 
		public WorldPosition WorldPosition
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		[Ordinal(1)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("forceMagnitude")] 
		public CFloat ForceMagnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("impulseMagnitude")] 
		public CFloat ImpulseMagnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxForceMagnitude")] 
		public CFloat MaxForceMagnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("maxImpulseMagnitude")] 
		public CFloat MaxImpulseMagnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("velocityChange")] 
		public CFloat VelocityChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("ragdollProxyActorIndex")] 
		public CUInt32 RagdollProxyActorIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("otherProxyActorIndex")] 
		public CUInt32 OtherProxyActorIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public entRagdollImpactPointData()
		{
			WorldPosition = new() { X = new(), Y = new(), Z = new() };
			WorldNormal = new() { W = 1.000000F };
			OtherProxyActorIndex = 1;
		}
	}
}
