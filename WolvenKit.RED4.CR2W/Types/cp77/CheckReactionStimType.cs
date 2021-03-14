using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckReactionStimType : AIbehaviorconditionScript
	{
		private CEnum<gamedataStimType> _stimToCompare;

		[Ordinal(0)] 
		[RED("stimToCompare")] 
		public CEnum<gamedataStimType> StimToCompare
		{
			get
			{
				if (_stimToCompare == null)
				{
					_stimToCompare = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "stimToCompare", cr2w, this);
				}
				return _stimToCompare;
			}
			set
			{
				if (_stimToCompare == value)
				{
					return;
				}
				_stimToCompare = value;
				PropertySet(this);
			}
		}

		public CheckReactionStimType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
