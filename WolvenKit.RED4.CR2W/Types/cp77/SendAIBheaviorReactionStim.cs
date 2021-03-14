using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendAIBheaviorReactionStim : AIbehaviortaskScript
	{
		private CEnum<gamedataStimType> _stimToSend;

		[Ordinal(0)] 
		[RED("stimToSend")] 
		public CEnum<gamedataStimType> StimToSend
		{
			get
			{
				if (_stimToSend == null)
				{
					_stimToSend = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "stimToSend", cr2w, this);
				}
				return _stimToSend;
			}
			set
			{
				if (_stimToSend == value)
				{
					return;
				}
				_stimToSend = value;
				PropertySet(this);
			}
		}

		public SendAIBheaviorReactionStim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
