using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCursorInfo : inkUserData
	{
		private Vector2 _pos;
		private CBool _isVisible;

		[Ordinal(0)] 
		[RED("pos")] 
		public Vector2 Pos
		{
			get
			{
				if (_pos == null)
				{
					_pos = (Vector2) CR2WTypeManager.Create("Vector2", "pos", cr2w, this);
				}
				return _pos;
			}
			set
			{
				if (_pos == value)
				{
					return;
				}
				_pos = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CBool) CR2WTypeManager.Create("Bool", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		public inkCursorInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
