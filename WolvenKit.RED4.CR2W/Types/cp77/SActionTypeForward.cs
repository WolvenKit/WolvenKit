using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SActionTypeForward : CVariable
	{
		private CBool _qHack;
		private CBool _techie;
		private CBool _master;

		[Ordinal(0)] 
		[RED("qHack")] 
		public CBool QHack
		{
			get
			{
				if (_qHack == null)
				{
					_qHack = (CBool) CR2WTypeManager.Create("Bool", "qHack", cr2w, this);
				}
				return _qHack;
			}
			set
			{
				if (_qHack == value)
				{
					return;
				}
				_qHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("techie")] 
		public CBool Techie
		{
			get
			{
				if (_techie == null)
				{
					_techie = (CBool) CR2WTypeManager.Create("Bool", "techie", cr2w, this);
				}
				return _techie;
			}
			set
			{
				if (_techie == value)
				{
					return;
				}
				_techie = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("master")] 
		public CBool Master
		{
			get
			{
				if (_master == null)
				{
					_master = (CBool) CR2WTypeManager.Create("Bool", "master", cr2w, this);
				}
				return _master;
			}
			set
			{
				if (_master == value)
				{
					return;
				}
				_master = value;
				PropertySet(this);
			}
		}

		public SActionTypeForward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
