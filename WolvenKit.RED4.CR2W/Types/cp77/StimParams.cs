using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimParams : CVariable
	{
		private ReactionOutput _reactionOutput;
		private StimEventData _stimData;

		[Ordinal(0)] 
		[RED("reactionOutput")] 
		public ReactionOutput ReactionOutput
		{
			get
			{
				if (_reactionOutput == null)
				{
					_reactionOutput = (ReactionOutput) CR2WTypeManager.Create("ReactionOutput", "reactionOutput", cr2w, this);
				}
				return _reactionOutput;
			}
			set
			{
				if (_reactionOutput == value)
				{
					return;
				}
				_reactionOutput = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stimData")] 
		public StimEventData StimData
		{
			get
			{
				if (_stimData == null)
				{
					_stimData = (StimEventData) CR2WTypeManager.Create("StimEventData", "stimData", cr2w, this);
				}
				return _stimData;
			}
			set
			{
				if (_stimData == value)
				{
					return;
				}
				_stimData = value;
				PropertySet(this);
			}
		}

		public StimParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
