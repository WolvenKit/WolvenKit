using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardEntryData : GenericCodexEntryData
	{
		private CBool _isCrypted;

		[Ordinal(10)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get => GetProperty(ref _isCrypted);
			set => SetProperty(ref _isCrypted, value);
		}

		public ShardEntryData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
