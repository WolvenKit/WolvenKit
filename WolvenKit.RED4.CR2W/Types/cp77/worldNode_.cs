using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNode_ : ISerializable
	{
		private CBool _isVisibleInGame;
		private CBool _isHostOnly;

		[Ordinal(2)] 
		[RED("isVisibleInGame")] 
		public CBool IsVisibleInGame
		{
			get
			{
				if (_isVisibleInGame == null)
				{
					_isVisibleInGame = (CBool) CR2WTypeManager.Create("Bool", "isVisibleInGame", cr2w, this);
				}
				return _isVisibleInGame;
			}
			set
			{
				if (_isVisibleInGame == value)
				{
					return;
				}
				_isVisibleInGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isHostOnly")] 
		public CBool IsHostOnly
		{
			get
			{
				if (_isHostOnly == null)
				{
					_isHostOnly = (CBool) CR2WTypeManager.Create("Bool", "isHostOnly", cr2w, this);
				}
				return _isHostOnly;
			}
			set
			{
				if (_isHostOnly == value)
				{
					return;
				}
				_isHostOnly = value;
				PropertySet(this);
			}
		}

		public worldNode_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
