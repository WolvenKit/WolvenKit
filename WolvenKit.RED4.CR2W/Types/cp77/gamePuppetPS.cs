using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePuppetPS : gameObjectPS
	{
		private CName _gender;
		private CBool _wasQuickHacked;
		private CBool _hasAlternativeName;
		private CBool _isCrouch;

		[Ordinal(0)] 
		[RED("gender")] 
		public CName Gender
		{
			get
			{
				if (_gender == null)
				{
					_gender = (CName) CR2WTypeManager.Create("CName", "gender", cr2w, this);
				}
				return _gender;
			}
			set
			{
				if (_gender == value)
				{
					return;
				}
				_gender = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get
			{
				if (_wasQuickHacked == null)
				{
					_wasQuickHacked = (CBool) CR2WTypeManager.Create("Bool", "wasQuickHacked", cr2w, this);
				}
				return _wasQuickHacked;
			}
			set
			{
				if (_wasQuickHacked == value)
				{
					return;
				}
				_wasQuickHacked = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hasAlternativeName")] 
		public CBool HasAlternativeName
		{
			get
			{
				if (_hasAlternativeName == null)
				{
					_hasAlternativeName = (CBool) CR2WTypeManager.Create("Bool", "hasAlternativeName", cr2w, this);
				}
				return _hasAlternativeName;
			}
			set
			{
				if (_hasAlternativeName == value)
				{
					return;
				}
				_hasAlternativeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isCrouch")] 
		public CBool IsCrouch
		{
			get
			{
				if (_isCrouch == null)
				{
					_isCrouch = (CBool) CR2WTypeManager.Create("Bool", "isCrouch", cr2w, this);
				}
				return _isCrouch;
			}
			set
			{
				if (_isCrouch == value)
				{
					return;
				}
				_isCrouch = value;
				PropertySet(this);
			}
		}

		public gamePuppetPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
