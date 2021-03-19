using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorUsedSpotTokensList : ISerializable
	{
		private CArray<AISpotUsageToken> _tokens;

		[Ordinal(0)] 
		[RED("tokens")] 
		public CArray<AISpotUsageToken> Tokens
		{
			get => GetProperty(ref _tokens);
			set => SetProperty(ref _tokens, value);
		}

		public AIbehaviorUsedSpotTokensList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
