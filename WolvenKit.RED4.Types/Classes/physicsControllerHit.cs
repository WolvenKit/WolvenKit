using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsControllerHit : RedBaseClass
	{
		private Vector4 _worldPos;
		private Vector4 _worldNormal;

		[Ordinal(0)] 
		[RED("worldPos")] 
		public Vector4 WorldPos
		{
			get => GetProperty(ref _worldPos);
			set => SetProperty(ref _worldPos, value);
		}

		[Ordinal(1)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get => GetProperty(ref _worldNormal);
			set => SetProperty(ref _worldNormal, value);
		}
	}
}
