using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetChancePrereq : gameIScriptablePrereq
	{
		private CFloat _setChance;

		[Ordinal(0)] 
		[RED("setChance")] 
		public CFloat SetChance
		{
			get => GetProperty(ref _setChance);
			set => SetProperty(ref _setChance, value);
		}
	}
}
