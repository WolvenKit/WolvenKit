using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectCarrierComponent : entIComponent
	{
		private TweakDBID _objectToSpawn;

		[Ordinal(3)] 
		[RED("objectToSpawn")] 
		public TweakDBID ObjectToSpawn
		{
			get => GetProperty(ref _objectToSpawn);
			set => SetProperty(ref _objectToSpawn, value);
		}
	}
}
