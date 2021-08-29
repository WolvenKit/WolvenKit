using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpExplosiveBarrel : gameDestructibleObject
	{
		private CName _colliderComponentName;
		private CName _destructionComponentName;

		[Ordinal(41)] 
		[RED("colliderComponentName")] 
		public CName ColliderComponentName
		{
			get => GetProperty(ref _colliderComponentName);
			set => SetProperty(ref _colliderComponentName, value);
		}

		[Ordinal(42)] 
		[RED("destructionComponentName")] 
		public CName DestructionComponentName
		{
			get => GetProperty(ref _destructionComponentName);
			set => SetProperty(ref _destructionComponentName, value);
		}
	}
}
