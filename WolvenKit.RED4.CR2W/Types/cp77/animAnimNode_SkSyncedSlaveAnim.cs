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
			get => GetProperty(ref _syncTag);
			set => SetProperty(ref _syncTag, value);
		}

		public animAnimNode_SkSyncedSlaveAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
