using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Knife : BaseProjectile
	{
		[Ordinal(51)] 
		[RED("collided")] 
		public CBool Collided
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
