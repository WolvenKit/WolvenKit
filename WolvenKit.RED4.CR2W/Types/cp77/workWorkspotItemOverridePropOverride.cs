using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotItemOverridePropOverride : CVariable
	{
		private CName _prevItemId;
		private CName _newItemId;

		[Ordinal(0)] 
		[RED("prevItemId")] 
		public CName PrevItemId
		{
			get
			{
				if (_prevItemId == null)
				{
					_prevItemId = (CName) CR2WTypeManager.Create("CName", "prevItemId", cr2w, this);
				}
				return _prevItemId;
			}
			set
			{
				if (_prevItemId == value)
				{
					return;
				}
				_prevItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("newItemId")] 
		public CName NewItemId
		{
			get
			{
				if (_newItemId == null)
				{
					_newItemId = (CName) CR2WTypeManager.Create("CName", "newItemId", cr2w, this);
				}
				return _newItemId;
			}
			set
			{
				if (_newItemId == value)
				{
					return;
				}
				_newItemId = value;
				PropertySet(this);
			}
		}

		public workWorkspotItemOverridePropOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
