using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkSyncedMasterAnim : animAnimNode_SkSpeedAnim
	{
		private CName _syncTag;

		[Ordinal(31)] 
		[RED("syncTag")] 
		public CName SyncTag
		{
			get => GetProperty(ref _syncTag);
			set => SetProperty(ref _syncTag, value);
		}

		public animAnimNode_SkSyncedMasterAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
