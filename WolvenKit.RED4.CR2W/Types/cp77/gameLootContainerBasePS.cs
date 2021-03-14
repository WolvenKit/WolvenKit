using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootContainerBasePS : gameObjectPS
	{
		private CBool _markAsQuest;
		private CBool _isDisabled;
		private CBool _isLocked;

		[Ordinal(0)] 
		[RED("markAsQuest")] 
		public CBool MarkAsQuest
		{
			get
			{
				if (_markAsQuest == null)
				{
					_markAsQuest = (CBool) CR2WTypeManager.Create("Bool", "markAsQuest", cr2w, this);
				}
				return _markAsQuest;
			}
			set
			{
				if (_markAsQuest == value)
				{
					return;
				}
				_markAsQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get
			{
				if (_isDisabled == null)
				{
					_isDisabled = (CBool) CR2WTypeManager.Create("Bool", "isDisabled", cr2w, this);
				}
				return _isDisabled;
			}
			set
			{
				if (_isDisabled == value)
				{
					return;
				}
				_isDisabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		public gameLootContainerBasePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
