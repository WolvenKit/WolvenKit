using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationBrokenNoseController : gameuiICharacterCustomizationComponent
	{
		private gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance _stage1App;
		private gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance _stage2App;

		[Ordinal(3)] 
		[RED("stage1App")] 
		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage1App
		{
			get
			{
				if (_stage1App == null)
				{
					_stage1App = (gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance) CR2WTypeManager.Create("gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance", "stage1App", cr2w, this);
				}
				return _stage1App;
			}
			set
			{
				if (_stage1App == value)
				{
					return;
				}
				_stage1App = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stage2App")] 
		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage2App
		{
			get
			{
				if (_stage2App == null)
				{
					_stage2App = (gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance) CR2WTypeManager.Create("gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance", "stage2App", cr2w, this);
				}
				return _stage2App;
			}
			set
			{
				if (_stage2App == value)
				{
					return;
				}
				_stage2App = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationBrokenNoseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
