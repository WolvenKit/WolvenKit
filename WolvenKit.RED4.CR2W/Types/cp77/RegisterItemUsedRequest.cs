using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterItemUsedRequest : gameScriptableSystemRequest
	{
		private gameItemID _itemUsed;

		[Ordinal(0)] 
		[RED("itemUsed")] 
		public gameItemID ItemUsed
		{
			get => GetProperty(ref _itemUsed);
			set => SetProperty(ref _itemUsed, value);
		}

		public RegisterItemUsedRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
