using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamesmartGunUISightParameters : RedBaseClass
	{
		private Vector2 _center;
		private Vector2 _targetableRegionSize;
		private Vector2 _reticleSize;

		[Ordinal(0)] 
		[RED("center")] 
		public Vector2 Center
		{
			get => GetProperty(ref _center);
			set => SetProperty(ref _center, value);
		}

		[Ordinal(1)] 
		[RED("targetableRegionSize")] 
		public Vector2 TargetableRegionSize
		{
			get => GetProperty(ref _targetableRegionSize);
			set => SetProperty(ref _targetableRegionSize, value);
		}

		[Ordinal(2)] 
		[RED("reticleSize")] 
		public Vector2 ReticleSize
		{
			get => GetProperty(ref _reticleSize);
			set => SetProperty(ref _reticleSize, value);
		}
	}
}
