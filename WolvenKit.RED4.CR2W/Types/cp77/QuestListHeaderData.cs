using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListHeaderData : IScriptable
	{
		private CInt32 _type;
		private CName _nameLocKey;

		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CInt32) CR2WTypeManager.Create("Int32", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nameLocKey")] 
		public CName NameLocKey
		{
			get
			{
				if (_nameLocKey == null)
				{
					_nameLocKey = (CName) CR2WTypeManager.Create("CName", "nameLocKey", cr2w, this);
				}
				return _nameLocKey;
			}
			set
			{
				if (_nameLocKey == value)
				{
					return;
				}
				_nameLocKey = value;
				PropertySet(this);
			}
		}

		public QuestListHeaderData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
