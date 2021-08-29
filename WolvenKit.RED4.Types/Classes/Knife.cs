using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Knife : BaseProjectile
	{
		private CBool _collided;

		[Ordinal(51)] 
		[RED("collided")] 
		public CBool Collided
		{
			get => GetProperty(ref _collided);
			set => SetProperty(ref _collided, value);
		}
	}
}
