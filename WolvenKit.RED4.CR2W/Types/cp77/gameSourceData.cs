using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSourceData : ISerializable
	{
		private CName _name;
		private CBool _savable;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("savable")] 
		public CBool Savable
		{
			get
			{
				if (_savable == null)
				{
					_savable = (CBool) CR2WTypeManager.Create("Bool", "savable", cr2w, this);
				}
				return _savable;
			}
			set
			{
				if (_savable == value)
				{
					return;
				}
				_savable = value;
				PropertySet(this);
			}
		}

		public gameSourceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
