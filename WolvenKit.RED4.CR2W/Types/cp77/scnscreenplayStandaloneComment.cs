using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayStandaloneComment : CVariable
	{
		private scnscreenplayItemId _itemId;
		private CString _comment;

		[Ordinal(0)] 
		[RED("itemId")] 
		public scnscreenplayItemId ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (scnscreenplayItemId) CR2WTypeManager.Create("scnscreenplayItemId", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("comment")] 
		public CString Comment
		{
			get
			{
				if (_comment == null)
				{
					_comment = (CString) CR2WTypeManager.Create("String", "comment", cr2w, this);
				}
				return _comment;
			}
			set
			{
				if (_comment == value)
				{
					return;
				}
				_comment = value;
				PropertySet(this);
			}
		}

		public scnscreenplayStandaloneComment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
