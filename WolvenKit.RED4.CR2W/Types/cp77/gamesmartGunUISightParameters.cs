using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunUISightParameters : CVariable
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

		public gamesmartGunUISightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
