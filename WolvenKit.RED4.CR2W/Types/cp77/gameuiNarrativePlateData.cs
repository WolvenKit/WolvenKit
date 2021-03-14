using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNarrativePlateData : CVariable
	{
		private CString _text;
		private CString _caption;
		private wCHandle<gameObject> _entity;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("caption")] 
		public CString Caption
		{
			get
			{
				if (_caption == null)
				{
					_caption = (CString) CR2WTypeManager.Create("String", "caption", cr2w, this);
				}
				return _caption;
			}
			set
			{
				if (_caption == value)
				{
					return;
				}
				_caption = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public wCHandle<gameObject> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		public gameuiNarrativePlateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
