using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneVOInfo : RedBaseClass
	{
		private CName _inVoTrigger;
		private CName _outVoTrigger;
		private CFloat _duration;
		private CUInt16 _id;

		[Ordinal(0)] 
		[RED("inVoTrigger")] 
		public CName InVoTrigger
		{
			get => GetProperty(ref _inVoTrigger);
			set => SetProperty(ref _inVoTrigger, value);
		}

		[Ordinal(1)] 
		[RED("outVoTrigger")] 
		public CName OutVoTrigger
		{
			get => GetProperty(ref _outVoTrigger);
			set => SetProperty(ref _outVoTrigger, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
