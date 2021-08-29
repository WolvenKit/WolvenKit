using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivateDevice : ActionBool
	{
		private CString _tweakDBChoiceName;

		[Ordinal(25)] 
		[RED("tweakDBChoiceName")] 
		public CString TweakDBChoiceName
		{
			get => GetProperty(ref _tweakDBChoiceName);
			set => SetProperty(ref _tweakDBChoiceName, value);
		}
	}
}
