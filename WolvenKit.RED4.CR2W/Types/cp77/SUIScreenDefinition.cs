using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SUIScreenDefinition : CVariable
	{
		private TweakDBID _screenDefinition;
		private TweakDBID _style;

		[Ordinal(0)] 
		[RED("screenDefinition")] 
		public TweakDBID ScreenDefinition
		{
			get
			{
				if (_screenDefinition == null)
				{
					_screenDefinition = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "screenDefinition", cr2w, this);
				}
				return _screenDefinition;
			}
			set
			{
				if (_screenDefinition == value)
				{
					return;
				}
				_screenDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("style")] 
		public TweakDBID Style
		{
			get
			{
				if (_style == null)
				{
					_style = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "style", cr2w, this);
				}
				return _style;
			}
			set
			{
				if (_style == value)
				{
					return;
				}
				_style = value;
				PropertySet(this);
			}
		}

		public SUIScreenDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
