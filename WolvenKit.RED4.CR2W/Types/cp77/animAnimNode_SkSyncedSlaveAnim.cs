using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkSyncedSlaveAnim : animAnimNode_SkAnim
	{
		private CName _syncTag;

		[Ordinal(30)] 
		[RED("syncTag")] 
		public CName SyncTag
		{
			get
			{
				if (_syncTag == null)
				{
					_syncTag = (CName) CR2WTypeManager.Create("CName", "syncTag", cr2w, this);
				}
				return _syncTag;
			}
			set
			{
				if (_syncTag == value)
				{
					return;
				}
				_syncTag = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkSyncedSlaveAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
