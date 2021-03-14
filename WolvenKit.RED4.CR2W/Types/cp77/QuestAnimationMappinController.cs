using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestAnimationMappinController : gameuiQuestMappinController
	{
		private wCHandle<gamemappinsQuestMappin> _mappin;
		private CHandle<gamedataUIAnimation_Record> _animationRecord;
		private CHandle<inkanimProxy> _animProxy;
		private CBool _playing;

		[Ordinal(14)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsQuestMappin> Mappin
		{
			get
			{
				if (_mappin == null)
				{
					_mappin = (wCHandle<gamemappinsQuestMappin>) CR2WTypeManager.Create("whandle:gamemappinsQuestMappin", "mappin", cr2w, this);
				}
				return _mappin;
			}
			set
			{
				if (_mappin == value)
				{
					return;
				}
				_mappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animationRecord")] 
		public CHandle<gamedataUIAnimation_Record> AnimationRecord
		{
			get
			{
				if (_animationRecord == null)
				{
					_animationRecord = (CHandle<gamedataUIAnimation_Record>) CR2WTypeManager.Create("handle:gamedataUIAnimation_Record", "animationRecord", cr2w, this);
				}
				return _animationRecord;
			}
			set
			{
				if (_animationRecord == value)
				{
					return;
				}
				_animationRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("playing")] 
		public CBool Playing
		{
			get
			{
				if (_playing == null)
				{
					_playing = (CBool) CR2WTypeManager.Create("Bool", "playing", cr2w, this);
				}
				return _playing;
			}
			set
			{
				if (_playing == value)
				{
					return;
				}
				_playing = value;
				PropertySet(this);
			}
		}

		public QuestAnimationMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
