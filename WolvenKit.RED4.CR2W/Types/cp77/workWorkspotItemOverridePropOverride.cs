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
			get => GetProperty(ref _prevItemId);
			set => SetProperty(ref _prevItemId, value);
		}

		[Ordinal(1)] 
		[RED("newItemId")] 
		public CName NewItemId
		{
			get => GetProperty(ref _newItemId);
			set => SetProperty(ref _newItemId, value);
		}

		public workWorkspotItemOverridePropOverride(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
