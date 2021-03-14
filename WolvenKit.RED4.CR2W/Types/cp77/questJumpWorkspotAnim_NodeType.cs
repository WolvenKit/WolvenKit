using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJumpWorkspotAnim_NodeType : questIBehaviourManager_NodeType
	{
		private CBool _allowCurrAnimToFinish;
		private CInt32 _entryIdToJumpTo;

		[Ordinal(1)] 
		[RED("allowCurrAnimToFinish")] 
		public CBool AllowCurrAnimToFinish
		{
			get
			{
				if (_allowCurrAnimToFinish == null)
				{
					_allowCurrAnimToFinish = (CBool) CR2WTypeManager.Create("Bool", "allowCurrAnimToFinish", cr2w, this);
				}
				return _allowCurrAnimToFinish;
			}
			set
			{
				if (_allowCurrAnimToFinish == value)
				{
					return;
				}
				_allowCurrAnimToFinish = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entryIdToJumpTo")] 
		public CInt32 EntryIdToJumpTo
		{
			get
			{
				if (_entryIdToJumpTo == null)
				{
					_entryIdToJumpTo = (CInt32) CR2WTypeManager.Create("Int32", "entryIdToJumpTo", cr2w, this);
				}
				return _entryIdToJumpTo;
			}
			set
			{
				if (_entryIdToJumpTo == value)
				{
					return;
				}
				_entryIdToJumpTo = value;
				PropertySet(this);
			}
		}

		public questJumpWorkspotAnim_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
