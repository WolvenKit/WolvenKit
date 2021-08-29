using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficStaticCollisionSphere : RedBaseClass
	{
		private Vector3 _worldPos;

		[Ordinal(0)] 
		[RED("worldPos")] 
		public Vector3 WorldPos
		{
			get => GetProperty(ref _worldPos);
			set => SetProperty(ref _worldPos, value);
		}
	}
}
