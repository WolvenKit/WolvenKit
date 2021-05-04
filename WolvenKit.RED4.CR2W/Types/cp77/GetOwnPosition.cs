using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetOwnPosition : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _outPosition;

		[Ordinal(0)] 
		[RED("outPosition")] 
		public CHandle<AIArgumentMapping> OutPosition
		{
			get => GetProperty(ref _outPosition);
			set => SetProperty(ref _outPosition, value);
		}

		public GetOwnPosition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
