using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_GameplayVo : animAnimEvent
	{
		private CName _voContext;
		private CBool _isQuest;

		[Ordinal(3)] 
		[RED("voContext")] 
		public CName VoContext
		{
			get
			{
				if (_voContext == null)
				{
					_voContext = (CName) CR2WTypeManager.Create("CName", "voContext", cr2w, this);
				}
				return _voContext;
			}
			set
			{
				if (_voContext == value)
				{
					return;
				}
				_voContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isQuest")] 
		public CBool IsQuest
		{
			get
			{
				if (_isQuest == null)
				{
					_isQuest = (CBool) CR2WTypeManager.Create("Bool", "isQuest", cr2w, this);
				}
				return _isQuest;
			}
			set
			{
				if (_isQuest == value)
				{
					return;
				}
				_isQuest = value;
				PropertySet(this);
			}
		}

		public animAnimEvent_GameplayVo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
