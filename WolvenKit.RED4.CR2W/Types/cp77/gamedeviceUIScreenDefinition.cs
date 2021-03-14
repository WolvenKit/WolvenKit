using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceUIScreenDefinition : CVariable
	{
		private TweakDBID _screenType;

		[Ordinal(0)] 
		[RED("screenType")] 
		public TweakDBID ScreenType
		{
			get
			{
				if (_screenType == null)
				{
					_screenType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "screenType", cr2w, this);
				}
				return _screenType;
			}
			set
			{
				if (_screenType == value)
				{
					return;
				}
				_screenType = value;
				PropertySet(this);
			}
		}

		public gamedeviceUIScreenDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
