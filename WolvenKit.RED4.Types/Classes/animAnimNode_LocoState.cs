using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_LocoState : animAnimNode_State
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
	}
}
