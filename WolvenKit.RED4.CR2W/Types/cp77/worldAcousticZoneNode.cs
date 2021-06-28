using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticZoneNode : worldNode
	{
		private CBool _isBlocker;
		private CName _tagName;
		private CFloat _tagSpread;

		[Ordinal(4)] 
		[RED("isBlocker")] 
		public CBool IsBlocker
		{
			get => GetProperty(ref _isBlocker);
			set => SetProperty(ref _isBlocker, value);
		}

		[Ordinal(5)] 
		[RED("tagName")] 
		public CName TagName
		{
			get => GetProperty(ref _tagName);
			set => SetProperty(ref _tagName, value);
		}

		[Ordinal(6)] 
		[RED("tagSpread")] 
		public CFloat TagSpread
		{
			get => GetProperty(ref _tagSpread);
			set => SetProperty(ref _tagSpread, value);
		}

		public worldAcousticZoneNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
