using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Stamina : animAnimFeature
	{
		private CFloat _staminaValue;
		private CFloat _tiredness;

		[Ordinal(0)] 
		[RED("staminaValue")] 
		public CFloat StaminaValue
		{
			get => GetProperty(ref _staminaValue);
			set => SetProperty(ref _staminaValue, value);
		}

		[Ordinal(1)] 
		[RED("tiredness")] 
		public CFloat Tiredness
		{
			get => GetProperty(ref _tiredness);
			set => SetProperty(ref _tiredness, value);
		}

		public AnimFeature_Stamina(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
