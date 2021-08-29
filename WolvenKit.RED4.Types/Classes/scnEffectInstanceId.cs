using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnEffectInstanceId : RedBaseClass
	{
		private scnEffectId _effectId;
		private CUInt32 _id;

		[Ordinal(0)] 
		[RED("effectId")] 
		public scnEffectId EffectId
		{
			get => GetProperty(ref _effectId);
			set => SetProperty(ref _effectId, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
