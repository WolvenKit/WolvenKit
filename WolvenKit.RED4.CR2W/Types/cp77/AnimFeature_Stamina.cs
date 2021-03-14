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
			get
			{
				if (_staminaValue == null)
				{
					_staminaValue = (CFloat) CR2WTypeManager.Create("Float", "staminaValue", cr2w, this);
				}
				return _staminaValue;
			}
			set
			{
				if (_staminaValue == value)
				{
					return;
				}
				_staminaValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tiredness")] 
		public CFloat Tiredness
		{
			get
			{
				if (_tiredness == null)
				{
					_tiredness = (CFloat) CR2WTypeManager.Create("Float", "tiredness", cr2w, this);
				}
				return _tiredness;
			}
			set
			{
				if (_tiredness == value)
				{
					return;
				}
				_tiredness = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Stamina(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
