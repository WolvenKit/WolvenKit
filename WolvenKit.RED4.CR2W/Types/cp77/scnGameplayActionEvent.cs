using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnGameplayActionEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CHandle<scnIGameplayActionData> _gameplayActionData;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get
			{
				if (_performer == null)
				{
					_performer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performer", cr2w, this);
				}
				return _performer;
			}
			set
			{
				if (_performer == value)
				{
					return;
				}
				_performer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("gameplayActionData")] 
		public CHandle<scnIGameplayActionData> GameplayActionData
		{
			get
			{
				if (_gameplayActionData == null)
				{
					_gameplayActionData = (CHandle<scnIGameplayActionData>) CR2WTypeManager.Create("handle:scnIGameplayActionData", "gameplayActionData", cr2w, this);
				}
				return _gameplayActionData;
			}
			set
			{
				if (_gameplayActionData == value)
				{
					return;
				}
				_gameplayActionData = value;
				PropertySet(this);
			}
		}

		public scnGameplayActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
