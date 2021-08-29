using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPuppeteerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questPuppetsEffector> _effector;
		private gameEntityReference _reference;

		[Ordinal(2)] 
		[RED("effector")] 
		public CHandle<questPuppetsEffector> Effector
		{
			get => GetProperty(ref _effector);
			set => SetProperty(ref _effector, value);
		}

		[Ordinal(3)] 
		[RED("reference")] 
		public gameEntityReference Reference
		{
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}
	}
}
