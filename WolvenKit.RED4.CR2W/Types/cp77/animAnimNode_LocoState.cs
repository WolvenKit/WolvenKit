using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocoState : animAnimNode_State
	{
		private CEnum<animLocoStateType> _type;
		private CName _locoTag;

		[Ordinal(17)] 
		[RED("type")] 
		public CEnum<animLocoStateType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(18)] 
		[RED("locoTag")] 
		public CName LocoTag
		{
			get => GetProperty(ref _locoTag);
			set => SetProperty(ref _locoTag, value);
		}

		public animAnimNode_LocoState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
