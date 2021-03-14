using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameEffectExecutor_StimOnHit : gameEffectExecutor_Scripted
	{
		private CEnum<gamedataStimType> _stimType;
		private CEnum<gamedataStimType> _silentStimType;

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

		[Ordinal(2)] 
		[RED("silentStimType")] 
		public CEnum<gamedataStimType> SilentStimType
		{
			get
			{
				if (_silentStimType == null)
				{
					_silentStimType = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "silentStimType", cr2w, this);
				}
				return _silentStimType;
			}
			set
			{
				if (_silentStimType == value)
				{
					return;
				}
				_silentStimType = value;
				PropertySet(this);
			}
		}

		public GameEffectExecutor_StimOnHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
