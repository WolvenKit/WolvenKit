using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VentilationAreaSetup : RedBaseClass
	{
		private CEnum<ETrapEffects> _areaEffect;
		private CName _actionName;

		[Ordinal(0)] 
		[RED("areaEffect")] 
		public CEnum<ETrapEffects> AreaEffect
		{
			get => GetProperty(ref _areaEffect);
			set => SetProperty(ref _areaEffect, value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		public VentilationAreaSetup()
		{
			_actionName = "Activate";
		}
	}
}
