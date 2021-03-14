using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestRandomizationSupervisor : genScriptedRandomizationSupervisor
	{
		private CBool _firstWasGenerated;

		[Ordinal(0)] 
		[RED("firstWasGenerated")] 
		public CBool FirstWasGenerated
		{
			get
			{
				if (_firstWasGenerated == null)
				{
					_firstWasGenerated = (CBool) CR2WTypeManager.Create("Bool", "firstWasGenerated", cr2w, this);
				}
				return _firstWasGenerated;
			}
			set
			{
				if (_firstWasGenerated == value)
				{
					return;
				}
				_firstWasGenerated = value;
				PropertySet(this);
			}
		}

		public TestRandomizationSupervisor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
