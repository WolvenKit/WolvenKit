using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePlayerCoverStatusChangedEvent : redEvent
	{
		private CEnum<gamePlayerCoverDirection> _direction;
		private CBool _fullyBehindCover;

		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<gamePlayerCoverDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<gamePlayerCoverDirection>) CR2WTypeManager.Create("gamePlayerCoverDirection", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fullyBehindCover")] 
		public CBool FullyBehindCover
		{
			get
			{
				if (_fullyBehindCover == null)
				{
					_fullyBehindCover = (CBool) CR2WTypeManager.Create("Bool", "fullyBehindCover", cr2w, this);
				}
				return _fullyBehindCover;
			}
			set
			{
				if (_fullyBehindCover == value)
				{
					return;
				}
				_fullyBehindCover = value;
				PropertySet(this);
			}
		}

		public gamePlayerCoverStatusChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
