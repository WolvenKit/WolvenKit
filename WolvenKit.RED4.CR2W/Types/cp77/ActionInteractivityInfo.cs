using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionInteractivityInfo : CVariable
	{
		private CBool _isExternal;
		private CBool _isRemote;
		private CBool _isDirect;

		[Ordinal(0)] 
		[RED("isExternal")] 
		public CBool IsExternal
		{
			get
			{
				if (_isExternal == null)
				{
					_isExternal = (CBool) CR2WTypeManager.Create("Bool", "isExternal", cr2w, this);
				}
				return _isExternal;
			}
			set
			{
				if (_isExternal == value)
				{
					return;
				}
				_isExternal = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get
			{
				if (_isRemote == null)
				{
					_isRemote = (CBool) CR2WTypeManager.Create("Bool", "isRemote", cr2w, this);
				}
				return _isRemote;
			}
			set
			{
				if (_isRemote == value)
				{
					return;
				}
				_isRemote = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isDirect")] 
		public CBool IsDirect
		{
			get
			{
				if (_isDirect == null)
				{
					_isDirect = (CBool) CR2WTypeManager.Create("Bool", "isDirect", cr2w, this);
				}
				return _isDirect;
			}
			set
			{
				if (_isDirect == value)
				{
					return;
				}
				_isDirect = value;
				PropertySet(this);
			}
		}

		public ActionInteractivityInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
