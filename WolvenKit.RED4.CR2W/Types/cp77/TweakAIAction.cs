using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIAction : TweakAIActionAbstract
	{
		private TweakDBID _record;

		[Ordinal(27)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}

		public TweakAIAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
