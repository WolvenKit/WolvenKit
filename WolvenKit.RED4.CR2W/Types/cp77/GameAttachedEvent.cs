using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameAttachedEvent : redEvent
	{
		private CBool _isGameplayRelevant;
		private CString _displayName;
		private TweakDBID _contentScale;

		[Ordinal(0)] 
		[RED("isGameplayRelevant")] 
		public CBool IsGameplayRelevant
		{
			get
			{
				if (_isGameplayRelevant == null)
				{
					_isGameplayRelevant = (CBool) CR2WTypeManager.Create("Bool", "isGameplayRelevant", cr2w, this);
				}
				return _isGameplayRelevant;
			}
			set
			{
				if (_isGameplayRelevant == value)
				{
					return;
				}
				_isGameplayRelevant = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (CString) CR2WTypeManager.Create("String", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get
			{
				if (_contentScale == null)
				{
					_contentScale = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "contentScale", cr2w, this);
				}
				return _contentScale;
			}
			set
			{
				if (_contentScale == value)
				{
					return;
				}
				_contentScale = value;
				PropertySet(this);
			}
		}

		public GameAttachedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
