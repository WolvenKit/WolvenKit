using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackTimeDilationOverride : redEvent
	{
		private CBool _overrideDilationToTutorialPreset;

		[Ordinal(0)] 
		[RED("overrideDilationToTutorialPreset")] 
		public CBool OverrideDilationToTutorialPreset
		{
			get
			{
				if (_overrideDilationToTutorialPreset == null)
				{
					_overrideDilationToTutorialPreset = (CBool) CR2WTypeManager.Create("Bool", "overrideDilationToTutorialPreset", cr2w, this);
				}
				return _overrideDilationToTutorialPreset;
			}
			set
			{
				if (_overrideDilationToTutorialPreset == value)
				{
					return;
				}
				_overrideDilationToTutorialPreset = value;
				PropertySet(this);
			}
		}

		public QuickHackTimeDilationOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
