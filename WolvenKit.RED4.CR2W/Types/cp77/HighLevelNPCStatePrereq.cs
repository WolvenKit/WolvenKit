using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighLevelNPCStatePrereq : NPCStatePrereq
	{
		private CEnum<gamedataNPCHighLevelState> _valueToListen;

		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CEnum<gamedataNPCHighLevelState> ValueToListen
		{
			get => GetProperty(ref _valueToListen);
			set => SetProperty(ref _valueToListen, value);
		}

		public HighLevelNPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
