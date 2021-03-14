using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGenericGameplayEventOccurredASTCD : audioAudioStateTransitionConditionData
	{
		private CName _gameplayEvent;

		[Ordinal(1)] 
		[RED("gameplayEvent")] 
		public CName GameplayEvent
		{
			get
			{
				if (_gameplayEvent == null)
				{
					_gameplayEvent = (CName) CR2WTypeManager.Create("CName", "gameplayEvent", cr2w, this);
				}
				return _gameplayEvent;
			}
			set
			{
				if (_gameplayEvent == value)
				{
					return;
				}
				_gameplayEvent = value;
				PropertySet(this);
			}
		}

		public audioGenericGameplayEventOccurredASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
