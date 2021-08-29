using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamebbScriptID : RedBaseClass
	{
		private gamebbID _none;

		[Ordinal(0)] 
		[RED("None")] 
		public gamebbID None
		{
			get => GetProperty(ref _none);
			set => SetProperty(ref _none, value);
		}
	}
}
