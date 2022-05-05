using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entRagdollBodyPartWaterImpactEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("linearVelocity")] 
		public Vector4 LinearVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("depthBelowSurface")] 
		public CFloat DepthBelowSurface
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("isTorso")] 
		public CBool IsTorso
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entRagdollBodyPartWaterImpactEvent()
		{
			WorldPosition = new();
			LinearVelocity = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
