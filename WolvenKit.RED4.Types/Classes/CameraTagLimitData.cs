using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraTagLimitData : IScriptable
	{
		private CBool _add;
		private CWeakHandle<SurveillanceCamera> _object;

		[Ordinal(0)] 
		[RED("add")] 
		public CBool Add
		{
			get => GetProperty(ref _add);
			set => SetProperty(ref _add, value);
		}

		[Ordinal(1)] 
		[RED("object")] 
		public CWeakHandle<SurveillanceCamera> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}
	}
}
