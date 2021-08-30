using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollImpactPointData : RedBaseClass
	{
		private WorldPosition _worldPosition;
		private Vector4 _worldNormal;
		private CFloat _forceMagnitude;
		private CFloat _impulseMagnitude;
		private CFloat _maxForceMagnitude;
		private CFloat _maxImpulseMagnitude;
		private CFloat _velocityChange;
		private CUInt32 _ragdollProxyActorIndex;
		private CUInt32 _otherProxyActorIndex;

		[Ordinal(0)] 
		[RED("worldPosition")] 
		public WorldPosition WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(1)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetProperty(ref _worldNormal);
			set => SetProperty(ref _worldNormal, value);
		}

		[Ordinal(2)] 
		[RED("forceMagnitude")] 
		public CFloat ForceMagnitude
		{
			get => GetProperty(ref _forceMagnitude);
			set => SetProperty(ref _forceMagnitude, value);
		}

		[Ordinal(3)] 
		[RED("impulseMagnitude")] 
		public CFloat ImpulseMagnitude
		{
			get => GetProperty(ref _impulseMagnitude);
			set => SetProperty(ref _impulseMagnitude, value);
		}

		[Ordinal(4)] 
		[RED("maxForceMagnitude")] 
		public CFloat MaxForceMagnitude
		{
			get => GetProperty(ref _maxForceMagnitude);
			set => SetProperty(ref _maxForceMagnitude, value);
		}

		[Ordinal(5)] 
		[RED("maxImpulseMagnitude")] 
		public CFloat MaxImpulseMagnitude
		{
			get => GetProperty(ref _maxImpulseMagnitude);
			set => SetProperty(ref _maxImpulseMagnitude, value);
		}

		[Ordinal(6)] 
		[RED("velocityChange")] 
		public CFloat VelocityChange
		{
			get => GetProperty(ref _velocityChange);
			set => SetProperty(ref _velocityChange, value);
		}

		[Ordinal(7)] 
		[RED("ragdollProxyActorIndex")] 
		public CUInt32 RagdollProxyActorIndex
		{
			get => GetProperty(ref _ragdollProxyActorIndex);
			set => SetProperty(ref _ragdollProxyActorIndex, value);
		}

		[Ordinal(8)] 
		[RED("otherProxyActorIndex")] 
		public CUInt32 OtherProxyActorIndex
		{
			get => GetProperty(ref _otherProxyActorIndex);
			set => SetProperty(ref _otherProxyActorIndex, value);
		}

		public entRagdollImpactPointData()
		{
			_otherProxyActorIndex = 1;
		}
	}
}
