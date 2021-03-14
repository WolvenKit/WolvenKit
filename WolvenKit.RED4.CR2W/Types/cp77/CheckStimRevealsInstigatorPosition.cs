using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckStimRevealsInstigatorPosition : AIbehaviorconditionScript
	{
		private CBool _checkStimType;
		private CEnum<gamedataStimType> _stimType;

		[Ordinal(0)] 
		[RED("checkStimType")] 
		public CBool CheckStimType
		{
			get
			{
				if (_checkStimType == null)
				{
					_checkStimType = (CBool) CR2WTypeManager.Create("Bool", "checkStimType", cr2w, this);
				}
				return _checkStimType;
			}
			set
			{
				if (_checkStimType == value)
				{
					return;
				}
				_checkStimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get
			{
				if (_stimType == null)
				{
					_stimType = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "stimType", cr2w, this);
				}
				return _stimType;
			}
			set
			{
				if (_stimType == value)
				{
					return;
				}
				_stimType = value;
				PropertySet(this);
			}
		}

		public CheckStimRevealsInstigatorPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
