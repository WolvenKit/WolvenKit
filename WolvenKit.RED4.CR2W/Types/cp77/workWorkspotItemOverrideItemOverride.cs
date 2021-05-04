using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotItemOverrideItemOverride : CVariable
	{
		private TweakDBID _prevItemId;
		private TweakDBID _newItemId;

		[Ordinal(0)] 
		[RED("prevItemId")] 
		public TweakDBID PrevItemId
		{
			get => GetProperty(ref _prevItemId);
			set => SetProperty(ref _prevItemId, value);
		}

		[Ordinal(1)] 
		[RED("newItemId")] 
		public TweakDBID NewItemId
		{
			get => GetProperty(ref _newItemId);
			set => SetProperty(ref _newItemId, value);
		}

		public workWorkspotItemOverrideItemOverride(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
